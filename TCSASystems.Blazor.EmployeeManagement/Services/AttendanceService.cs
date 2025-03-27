using Microsoft.EntityFrameworkCore;
using TCSASystems.Blazor.EmployeeManagement.Data;
using TCSASystems.Blazor.EmployeeManagement.Models;
using System.Data;

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
    private readonly DataContext _context;

    public AttendanceService(DataContext context)
    {
        _context = context;
    }

    public async Task AddAttendance(Attendance attendance)
    {
        // Validate employee exists
        var employee = await _context.Employees.FindAsync(attendance.EmployeeId);
        if (employee == null)
        {
            throw new InvalidOperationException($"Employee with ID {attendance.EmployeeId} not found.");
        }

        // Validate date is not in the future
        if (attendance.Date.Date > DateTime.Now.Date)
        {
            throw new InvalidOperationException("Cannot record attendance for future dates.");
        }

        // Validate check-out time is after check-in time if provided
        if (attendance.CheckOut.HasValue && attendance.CheckOut.Value <= attendance.CheckIn)
        {
            throw new InvalidOperationException("Check-out time must be after check-in time.");
        }

        // Check for existing attendance record
        var existingAttendance = await _context.Attendances
            .FirstOrDefaultAsync(a => 
                a.EmployeeId == attendance.EmployeeId && 
                a.Date.Date == attendance.Date.Date);

        if (existingAttendance != null)
        {
            // Update existing record
            existingAttendance.CheckIn = attendance.CheckIn;
            existingAttendance.CheckOut = attendance.CheckOut;
            _context.Attendances.Update(existingAttendance);
        }
        else
        {
            // Add new record
            _context.Attendances.Add(attendance);
        }

        await _context.SaveChangesAsync();
    }

    public async Task UpdateAttendance(Attendance attendance)
    {
        var existingAttendance = await _context.Attendances.FindAsync(attendance.Id);

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
        
        await _context.SaveChangesAsync();
    }

    public async Task<List<Attendance>> GetAttendancesByEmployeeId(int employeeId)
    {
        return await _context.Attendances
            .Include(a => a.Employee)
            .Where(a => a.EmployeeId == employeeId)
            .OrderByDescending(a => a.Date)
            .ToListAsync();
    }

    public async Task<List<Attendance>> GetAttendancesByDateRange(DateTime startDate, DateTime endDate)
    {
        return await _context.Attendances
            .Include(a => a.Employee)
            .Where(a => a.Date >= startDate && a.Date <= endDate)
            .OrderByDescending(a => a.Date)
            .ToListAsync();
    }

    public async Task<Attendance?> GetAttendanceById(int id)
    {
        return await _context.Attendances
            .Include(a => a.Employee)
            .FirstOrDefaultAsync(a => a.Id == id);
    }
}
