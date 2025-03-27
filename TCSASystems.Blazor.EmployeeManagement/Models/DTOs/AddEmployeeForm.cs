using System.ComponentModel.DataAnnotations;

namespace TCSASystems.Blazor.EmployeeManagement.Models.DTOs;

public class AddEmployeeForm
{
    [Required]
    public string Name { get; set; }

    public decimal Salary { get; set; } = 0;

    [Required]
    public decimal HourlyRate { get; set; }

    [Required]
    public EmployeeType Type { get; set; }

    [Required]
    public Position Position { get; set; }

    public string? ImgUrl { get; set; }
}
