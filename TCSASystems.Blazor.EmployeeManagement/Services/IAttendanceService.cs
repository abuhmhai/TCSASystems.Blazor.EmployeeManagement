using TCSASystems.Blazor.EmployeeManagement.Models;

namespace TCSASystems.Blazor.EmployeeManagement.Services;

public interface IAttendanceService
{
    Task AddAttendance(Attendance attendance);
    Task<List<Attendance>> GetAttendancesByEmployeeId(int employeeId);
    Task<List<Attendance>> GetAttendancesByDateRange(DateTime startDate, DateTime endDate);
}
