using System.Net.Http.Json;
using TCSASystems.Blazor.EmployeeManagement.Models;
using TCSASystems.Blazor.EmployeeManagement.Models.Responses;

namespace TCSASystems.Blazor.EmployeeManagement.Services;

public class EmployeeService : IEmployeeService
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl = "api/employees/";

    public EmployeeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ServiceResponse<Employee>> AddEmployee(Employee employee)
    {
        var response = await _httpClient.PostAsJsonAsync(_baseUrl, employee);
        return await response.Content.ReadFromJsonAsync<ServiceResponse<Employee>>() 
            ?? new ServiceResponse<Employee> { StatusCode = 500, Message = "Failed to add employee" };
    }

    public async Task<ServiceResponse<List<Employee>>> GetAllEmployees()
    {
        var response = await _httpClient.GetAsync(_baseUrl);
        return await response.Content.ReadFromJsonAsync<ServiceResponse<List<Employee>>>() 
            ?? new ServiceResponse<List<Employee>> { StatusCode = 500, Message = "Failed to get employees" };
    }

    public async Task<ServiceResponse<Employee>> GetEmployeeById(int id)
    {
        var response = await _httpClient.GetAsync($"{_baseUrl}{id}");
        return await response.Content.ReadFromJsonAsync<ServiceResponse<Employee>>() 
            ?? new ServiceResponse<Employee> { StatusCode = 404, Message = "Failed to get employee" };
    }

    public async Task<ServiceResponse<Employee>> UpdateEmployee(Employee employee)
    {
        var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}{employee.Id}", employee);
        return await response.Content.ReadFromJsonAsync<ServiceResponse<Employee>>() 
            ?? new ServiceResponse<Employee> { StatusCode = 500, Message = "Failed to update employee" };
    }

    public async Task<ServiceResponse<bool>> DeleteEmployee(int id)
    {
        var response = await _httpClient.DeleteAsync($"{_baseUrl}{id}");
        return await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>() 
            ?? new ServiceResponse<bool> { StatusCode = 500, Message = "Failed to delete employee" };
    }
}
