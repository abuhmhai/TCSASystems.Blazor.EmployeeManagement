using Microsoft.EntityFrameworkCore;
using TCSASystems.Blazor.EmployeeManagement.Data;
using TCSASystems.Blazor.EmployeeManagement.Models;
using System.Data;
using Microsoft.Extensions.Logging;

namespace TCSASystems.Blazor.EmployeeManagement.Services;

public interface IAttendanceService
{
    Task AddAttendance(Attendance attendance);
    Task<List<Attendance>> GetAttendancesByEmployeeId(int employeeId);
    Task<List<Attendance>> GetAttendancesByDateRange(DateTime startDate, DateTime endDate);
    Task<Attendance?> GetAttendanceById(int id);
    Task UpdateAttendance(Attendance attendance);
}

public class AttendanceService : IAttendanceService
{
    private readonly IDbContextFactory<DataContext> _contextFactory;
    private readonly ILogger<AttendanceService> _logger;

    public AttendanceService(IDbContextFactory<DataContext> contextFactory, ILogger<AttendanceService> logger)
    {
        _contextFactory = contextFactory;
        _logger = logger;
    }

    public async Task AddAttendance(Attendance attendance)
    {
        _logger.LogInformation($"Adding attendance record for Employee {attendance.EmployeeId} on {attendance.Date:yyyy-MM-dd}");
        
        using var context = await _contextFactory.CreateDbContextAsync();
        
        // Validate employee exists
        var employee = await context.Employees.FindAsync(attendance.EmployeeId);
        if (employee == null)
        {
            _logger.LogWarning($"Employee with ID {attendance.EmployeeId} not found");
            throw new InvalidOperationException($"Employee with ID {attendance.EmployeeId} not found.");
        }

        // Validate date is not in the future
        if (attendance.Date.Date > DateTime.Now.Date)
        {
            _logger.LogWarning($"Attempted to record attendance for future date: {attendance.Date:yyyy-MM-dd}");
            throw new InvalidOperationException("Cannot record attendance for future dates.");
        }

        // Validate check-out time is after check-in time if provided
        if (attendance.CheckOut.HasValue && attendance.CheckOut.Value <= attendance.CheckIn)
        {
            _logger.LogWarning($"Invalid check-out time: CheckIn={attendance.CheckIn:HH:mm}, CheckOut={attendance.CheckOut.Value:HH:mm}");
            throw new InvalidOperationException("Check-out time must be after check-in time.");
        }

        try
        {
            // Check for existing attendance record
            var existingAttendance = await context.Attendances
                .FirstOrDefaultAsync(a => 
                    a.EmployeeId == attendance.EmployeeId && 
                    a.Date.Date == attendance.Date.Date);

            if (existingAttendance != null)
            {
                _logger.LogInformation($"Updating existing attendance record (ID: {existingAttendance.Id})");
                // Update existing record
                existingAttendance.CheckIn = attendance.CheckIn;
                existingAttendance.CheckOut = attendance.CheckOut;
                context.Attendances.Update(existingAttendance);
            }
            else
            {
                _logger.LogInformation("Creating new attendance record");
                // Add new record
                context.Attendances.Add(attendance);
            }

            await context.SaveChangesAsync();
            _logger.LogInformation("Attendance record saved successfully");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error saving attendance record");
            throw;
        }
    }

    public async Task UpdateAttendance(Attendance attendance)
    {
        using var context = await _contextFactory.CreateDbContextAsync();
        var existingAttendance = await context.Attendances.FindAsync(attendance.Id);

        if (existingAttendance == null)
        {
            throw new InvalidOperationException($"Attendance record with ID {attendance.Id} not found.");
        }

        // Validate check-out time is after check-in time if provided
        if (attendance.CheckOut.HasValue && attendance.CheckOut.Value <= attendance.CheckIn)
        {
            throw new InvalidOperationException("Check-out time must be after check-in time.");
        }

        existingAttendance.CheckIn = attendance.CheckIn;
        existingAttendance.CheckOut = attendance.CheckOut;
        
        await context.SaveChangesAsync();
    }

    public async Task<List<Attendance>> GetAttendancesByEmployeeId(int employeeId)
    {
        using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Attendances
            .Include(a => a.Employee)
            .Where(a => a.EmployeeId == employeeId)
            .OrderByDescending(a => a.Date)
            .ToListAsync();
    }

    public async Task<List<Attendance>> GetAttendancesByDateRange(DateTime startDate, DateTime endDate)
    {
        using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Attendances
            .Include(a => a.Employee)
            .Where(a => a.Date >= startDate && a.Date <= endDate)
            .OrderByDescending(a => a.Date)
            .ToListAsync();
    }

    public async Task<Attendance?> GetAttendanceById(int id)
    {
        using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Attendances
            .Include(a => a.Employee)
            .FirstOrDefaultAsync(a => a.Id == id);
    }
}
