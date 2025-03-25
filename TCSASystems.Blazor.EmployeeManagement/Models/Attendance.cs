using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCSASystems.Blazor.EmployeeManagement.Models;

public class Attendance
{
    [Key]
    public int Id { get; set; }

    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    public DateTime Date { get; set; }
    public TimeOnly CheckIn { get; set; }
    public TimeOnly? CheckOut { get; set; }

    [NotMapped]
    public double HoursWorked => CheckOut.HasValue
        ? (CheckOut.Value - CheckIn).TotalHours
        : 0;

    public bool IsLate => CheckIn > new TimeOnly(9, 0); // Đi muộn nếu sau 9:00 AM
}
