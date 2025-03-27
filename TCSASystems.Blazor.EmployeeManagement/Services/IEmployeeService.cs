using TCSASystems.Blazor.EmployeeManagement.Models;
using TCSASystems.Blazor.EmployeeManagement.Models.Responses;

namespace TCSASystems.Blazor.EmployeeManagement.Services;

public interface IEmployeeService
{
    Task<ServiceResponse<Employee>> AddEmployee(Employee employee);
    Task<ServiceResponse<List<Employee>>> GetAllEmployees();
    Task<ServiceResponse<Employee>> GetEmployeeById(int id);
    Task<ServiceResponse<Employee>> UpdateEmployee(Employee employee);
    Task<ServiceResponse<bool>> DeleteEmployee(int id);
} 