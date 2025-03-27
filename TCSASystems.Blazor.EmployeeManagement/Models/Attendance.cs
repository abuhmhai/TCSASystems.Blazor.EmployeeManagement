using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCSASystems.Blazor.EmployeeManagement.Models;

public class Attendance
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [Required]
    [DataType(DataType.Time)]
    public TimeOnly CheckIn { get; set; }

    [DataType(DataType.Time)]
    public TimeOnly? CheckOut { get; set; }

    [NotMapped]
    public double HoursWorked
    {
        get
        {
            if (!CheckOut.HasValue) return 0;
            var duration = CheckOut.Value - CheckIn;
            return Math.Max(0, duration.TotalHours);
        }
    }

    [NotMapped]
    public bool IsLate => CheckIn > new TimeOnly(9, 0); // Late if after 9:00 AM

    [NotMapped]
    public bool IsValid => CheckOut == null || CheckOut.Value > CheckIn;
}
