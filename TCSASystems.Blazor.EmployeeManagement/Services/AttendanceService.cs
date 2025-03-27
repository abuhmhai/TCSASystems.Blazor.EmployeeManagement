using Microsoft.EntityFrameworkCore;
using TCSASystems.Blazor.EmployeeManagement.Data;
using TCSASystems.Blazor.EmployeeManagement.Models;

namespace TCSASystems.Blazor.EmployeeManagement.Services;

public class AttendanceService : IAttendanceService
{
    private readonly DataContext _context;

    public AttendanceService(DataContext context)
    {
        _context = context;
    }

    public async Task AddAttendance(Attendance attendance)
    {
        try
        {
            // Validate employee exists
            var employee = await _context.Employees.FindAsync(attendance.EmployeeId);
            if (employee == null)
            {
                throw new InvalidOperationException($"Employee with ID {attendance.EmployeeId} not found.");
            }

            // Validate date is not in the future
            if (attendance.Date.Date > DateTime.Today)
            {
                throw new InvalidOperationException("Cannot record attendance for future dates.");
            }

            // Validate check-out time is after check-in time if provided
            if (attendance.CheckOut.HasValue && attendance.CheckOut.Value <= attendance.CheckIn)
            {
                throw new InvalidOperationException("Check-out time must be after check-in time.");
            }

            // Check for duplicate attendance record
            var existingAttendance = await _context.Attendances
                .FirstOrDefaultAsync(a => 
                    a.EmployeeId == attendance.EmployeeId && 
                    a.Date.Date == attendance.Date.Date);

            if (existingAttendance != null)
            {
                throw new InvalidOperationException($"Attendance record already exists for employee {employee.Name} on {attendance.Date:yyyy-MM-dd}.");
            }

            _context.Attendances.Add(attendance);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException ex)
        {
            throw new InvalidOperationException($"Database error while saving attendance: {ex.Message}", ex);
        }
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
