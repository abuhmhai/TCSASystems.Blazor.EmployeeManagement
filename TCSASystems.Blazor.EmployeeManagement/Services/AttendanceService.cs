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
        _context.Attendances.Add(attendance);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Attendance>> GetAttendancesByEmployeeId(int employeeId)
    {
        return await _context.Attendances
            .Include(a => a.Employee)
            .Where(a => a.EmployeeId == employeeId)
            .ToListAsync();
    }

    public async Task<List<Attendance>> GetAttendancesByDateRange(DateTime startDate, DateTime endDate)
    {
        return await _context.Attendances
            .Include(a => a.Employee)
            .Where(a => a.Date >= startDate && a.Date <= endDate)
            .ToListAsync();
    }
}
