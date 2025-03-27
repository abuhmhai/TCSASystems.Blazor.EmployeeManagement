using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TCSASystems.Blazor.EmployeeManagement.Models;

public class Employee
{
    public int Id { get; set; }

    [Required]
    public required string Name { get; set; }

    public string? ImgUrl { get; set; }

    public decimal? Salary { get; set; }

    public decimal? HourlyRate { get; set; }

    [Required]
    public EmployeeType Type { get; set; }

    [Required]
    public Position Position { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
    public virtual ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();
}

public enum EmployeeType
{
    FullTime,
    PartTime,
    Casual,
    Freelance
}

public enum Position
{
    CEO,
    CFO,
    CTO,
    SoftwareEngineer,
    DataAnalyst,
    ProjectManager,
    HRManager,
    AccountManager,
    MarketingManager,
    SalesRepresentative,
    CustomerServiceRepresentative,
    Other
}

public static class PositionExtensions
{
    public static string GetDisplayName(this Position position)
    {
        return position switch
        {
            Position.CEO => "Chief Executive Officer",
            Position.CFO => "Chief Financial Officer",
            Position.CTO => "Chief Technology Officer",
            Position.SoftwareEngineer => "Software Engineer",
            Position.DataAnalyst => "Data Analyst",
            Position.ProjectManager => "Project Manager",
            Position.HRManager => "HR Manager",
            Position.AccountManager => "Account Manager",
            Position.MarketingManager => "Marketing Manager",
            Position.SalesRepresentative => "Sales Representative",
            Position.CustomerServiceRepresentative => "Customer Service Representative",
            Position.Other => "Other",
            _ => position.ToString()
        };
    }
}
