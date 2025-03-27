using TCSASystems.Blazor.EmployeeManagement.Models;

namespace TCSASystems.Blazor.EmployeeManagement.Services;

public interface IPayrollService
{
    decimal CalculatePayroll(Employee employee, int hoursWorked);
    decimal GetDefaultHourlyRate(EmployeeType type, Position position);
}

public class PayrollService : IPayrollService
{
    private readonly Dictionary<(EmployeeType, Position), decimal> _defaultHourlyRates = new()
    {
        // CEO
        {(EmployeeType.FullTime, Position.CEO), 150.00m},
        {(EmployeeType.PartTime, Position.CEO), 120.00m},
        
        // CFO
        {(EmployeeType.FullTime, Position.CFO), 130.00m},
        {(EmployeeType.PartTime, Position.CFO), 100.00m},
        
        // CTO
        {(EmployeeType.FullTime, Position.CTO), 140.00m},
        {(EmployeeType.PartTime, Position.CTO), 110.00m},
        
        // Accountant
        {(EmployeeType.FullTime, Position.Accountant), 80.00m},
        {(EmployeeType.PartTime, Position.Accountant), 60.00m},
        {(EmployeeType.Casual, Position.Accountant), 50.00m},
        
        // HR Manager
        {(EmployeeType.FullTime, Position.HRManager), 90.00m},
        {(EmployeeType.PartTime, Position.HRManager), 70.00m},
        
        // Marketing Manager
        {(EmployeeType.FullTime, Position.MarketingManager), 85.00m},
        {(EmployeeType.PartTime, Position.MarketingManager), 65.00m},
        
        // Sales Manager
        {(EmployeeType.FullTime, Position.SalesManager), 95.00m},
        {(EmployeeType.PartTime, Position.SalesManager), 75.00m},
        
        // Software Engineer
        {(EmployeeType.FullTime, Position.SoftwareEngineer), 100.00m},
        {(EmployeeType.PartTime, Position.SoftwareEngineer), 80.00m},
        {(EmployeeType.Freelance, Position.SoftwareEngineer), 120.00m},
        
        // Data Analyst
        {(EmployeeType.FullTime, Position.DataAnalyst), 85.00m},
        {(EmployeeType.PartTime, Position.DataAnalyst), 65.00m},
        {(EmployeeType.Casual, Position.DataAnalyst), 55.00m},
        
        // Customer Support
        {(EmployeeType.FullTime, Position.CustomerSupport), 45.00m},
        {(EmployeeType.PartTime, Position.CustomerSupport), 35.00m},
        {(EmployeeType.Casual, Position.CustomerSupport), 30.00m},
    };

    public decimal CalculatePayroll(Employee employee, int hoursWorked)
    {
        var hourlyRate = employee.HourlyRate > 0 ? employee.HourlyRate : GetDefaultHourlyRate(employee.Type, employee.Position);
        
        // Calculate base pay
        decimal basePay = hourlyRate * hoursWorked;

        // Apply overtime for full-time employees (over 40 hours)
        if (employee.Type == EmployeeType.FullTime && hoursWorked > 40)
        {
            decimal overtimeHours = hoursWorked - 40;
            decimal overtimeRate = hourlyRate * 1.5m;
            basePay += overtimeHours * overtimeRate;
        }

        return basePay;
    }

    public decimal GetDefaultHourlyRate(EmployeeType type, Position position)
    {
        return _defaultHourlyRates.TryGetValue((type, position), out decimal rate) 
            ? rate 
            : 50.00m; // Default rate if not found
    }
} 