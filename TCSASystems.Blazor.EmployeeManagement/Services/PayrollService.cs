using TCSASystems.Blazor.EmployeeManagement.Models;
using ClosedXML.Excel;
using System.IO;

namespace TCSASystems.Blazor.EmployeeManagement.Services;

public interface IPayrollService
{
    decimal CalculatePayroll(Employee employee, int hoursWorked);
    decimal GetDefaultHourlyRate(EmployeeType type, Position position);
    byte[] GeneratePayrollExcel(List<Attendance> attendances, DateTime startDate, DateTime endDate);
    byte[] GeneratePayrollSummaryExcel(dynamic payrollData, DateTime startDate, DateTime endDate);
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

    public byte[] GeneratePayrollExcel(List<Attendance> attendances, DateTime startDate, DateTime endDate)
    {
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Payroll Report");

        // Add title
        worksheet.Cell("A1").Value = "Payroll Report";
        worksheet.Cell("A1").Style.Font.Bold = true;
        worksheet.Cell("A1").Style.Font.FontSize = 14;
        worksheet.Range("A1:D1").Merge();

        // Add date range
        worksheet.Cell("A2").Value = $"Period: {startDate:MM/dd/yyyy} to {endDate:MM/dd/yyyy}";
        worksheet.Range("A2:D2").Merge();

        // Add headers
        worksheet.Cell("A4").Value = "Employee Name";
        worksheet.Cell("B4").Value = "Position";
        worksheet.Cell("C4").Value = "Date";
        worksheet.Cell("D4").Value = "Check In";
        worksheet.Cell("E4").Value = "Check Out";
        worksheet.Cell("F4").Value = "Hours Worked";
        worksheet.Cell("G4").Value = "Hourly Rate";
        worksheet.Cell("H4").Value = "Daily Pay";

        // Style headers
        var headerRange = worksheet.Range("A4:H4");
        headerRange.Style.Font.Bold = true;
        headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;

        // Add data
        int row = 5;
        var groupedAttendances = attendances
            .OrderBy(a => a.Employee?.Name)
            .ThenBy(a => a.Date)
            .GroupBy(a => a.EmployeeId);

        foreach (var group in groupedAttendances)
        {
            var employee = group.First().Employee;
            if (employee == null) continue;

            // Add employee info
            worksheet.Cell($"A{row}").Value = employee.Name;
            worksheet.Cell($"B{row}").Value = employee.Position.GetDisplayName();
            worksheet.Cell($"G{row}").Value = employee.HourlyRate;

            // Add attendance records
            foreach (var attendance in group)
            {
                worksheet.Cell($"C{row}").Value = attendance.Date;
                worksheet.Cell($"D{row}").Value = attendance.CheckIn.ToString("HH:mm");
                worksheet.Cell($"E{row}").Value = attendance.CheckOut?.ToString("HH:mm") ?? "";
                worksheet.Cell($"F{row}").Value = attendance.HoursWorked;
                worksheet.Cell($"H{row}").Value = attendance.HoursWorked * (double)employee.HourlyRate;
                row++;
            }

            // Add subtotal row
            var subtotalRow = row;
            worksheet.Cell($"A{subtotalRow}").Value = "Subtotal";
            worksheet.Cell($"F{subtotalRow}").Value = group.Sum(a => a.HoursWorked);
            worksheet.Cell($"H{subtotalRow}").Value = group.Sum(a => a.HoursWorked * (double)employee.HourlyRate);
            worksheet.Range($"A{subtotalRow}:H{subtotalRow}").Style.Font.Bold = true;
            row++;
        }

        // Add grand total
        var grandTotalRow = row;
        worksheet.Cell($"A{grandTotalRow}").Value = "Grand Total";
        worksheet.Cell($"F{grandTotalRow}").Value = attendances.Sum(a => a.HoursWorked);
        worksheet.Cell($"H{grandTotalRow}").Value = attendances.Sum(a => a.HoursWorked * (double)a.Employee!.HourlyRate);
        worksheet.Range($"A{grandTotalRow}:H{grandTotalRow}").Style.Font.Bold = true;
        worksheet.Range($"A{grandTotalRow}:H{grandTotalRow}").Style.Fill.BackgroundColor = XLColor.LightGray;

        // Auto-fit columns
        worksheet.Columns().AdjustToContents();

        // Save to memory stream
        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        return stream.ToArray();
    }

    public byte[] GeneratePayrollSummaryExcel(dynamic payrollData, DateTime startDate, DateTime endDate)
    {
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Payroll Summary");

        // Add title
        worksheet.Cell("A1").Value = "Payroll Summary Report";
        worksheet.Cell("A1").Style.Font.Bold = true;
        worksheet.Cell("A1").Style.Font.FontSize = 14;
        worksheet.Range("A1:H1").Merge();

        // Add date range
        worksheet.Cell("A2").Value = $"Period: {startDate:MM/dd/yyyy} to {endDate:MM/dd/yyyy}";
        worksheet.Range("A2:H2").Merge();

        // Add headers
        worksheet.Cell("A4").Value = "Employee Name";
        worksheet.Cell("B4").Value = "Position";
        worksheet.Cell("C4").Value = "Employment Type";
        worksheet.Cell("D4").Value = "Hourly Rate";
        worksheet.Cell("E4").Value = "Total Hours";
        worksheet.Cell("F4").Value = "Regular Hours";
        worksheet.Cell("G4").Value = "Overtime Hours";
        worksheet.Cell("H4").Value = "Total Pay";

        // Style headers
        var headerRange = worksheet.Range("A4:H4");
        headerRange.Style.Font.Bold = true;
        headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;

        // Add data
        int row = 5;
        decimal totalPay = 0;
        double totalHours = 0;
        double totalRegularHours = 0;
        double totalOvertimeHours = 0;

        foreach (var record in payrollData)
        {
            worksheet.Cell($"A{row}").Value = record.EmployeeName;
            worksheet.Cell($"B{row}").Value = record.Position;
            worksheet.Cell($"C{row}").Value = record.EmploymentType;
            worksheet.Cell($"D{row}").Value = record.HourlyRate;
            worksheet.Cell($"E{row}").Value = record.TotalHours;
            worksheet.Cell($"F{row}").Value = record.RegularHours;
            worksheet.Cell($"G{row}").Value = record.OvertimeHours;
            worksheet.Cell($"H{row}").Value = record.TotalPay;

            // Update totals
            totalPay += record.TotalPay;
            totalHours += record.TotalHours;
            totalRegularHours += record.RegularHours;
            totalOvertimeHours += record.OvertimeHours;

            row++;
        }

        // Add totals row
        var totalRow = row;
        worksheet.Cell($"A{totalRow}").Value = "Total";
        worksheet.Cell($"E{totalRow}").Value = totalHours;
        worksheet.Cell($"F{totalRow}").Value = totalRegularHours;
        worksheet.Cell($"G{totalRow}").Value = totalOvertimeHours;
        worksheet.Cell($"H{totalRow}").Value = totalPay;

        // Style totals row
        var totalsRange = worksheet.Range($"A{totalRow}:H{totalRow}");
        totalsRange.Style.Font.Bold = true;
        totalsRange.Style.Fill.BackgroundColor = XLColor.LightGray;

        // Format currency columns
        worksheet.Column(4).Style.NumberFormat.Format = "$#,##0.00"; // Hourly Rate
        worksheet.Column(8).Style.NumberFormat.Format = "$#,##0.00"; // Total Pay

        // Format hours columns
        worksheet.Column(5).Style.NumberFormat.Format = "#,##0.0"; // Total Hours
        worksheet.Column(6).Style.NumberFormat.Format = "#,##0.0"; // Regular Hours
        worksheet.Column(7).Style.NumberFormat.Format = "#,##0.0"; // Overtime Hours

        // Auto-fit columns
        worksheet.Columns().AdjustToContents();

        // Save to memory stream
        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        return stream.ToArray();
    }
} 