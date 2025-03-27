using System.ComponentModel.DataAnnotations;

namespace TCSASystems.Blazor.EmployeeManagement.Models;

public class Payroll
{
    public int Id { get; set; }
    
    [Required]
    public int EmployeeId { get; set; }
    
    [Required]
    public DateTime PayPeriodStart { get; set; }
    
    [Required]
    public DateTime PayPeriodEnd { get; set; }
    
    [Required]
    public decimal GrossPay { get; set; }
    
    [Required]
    public decimal NetPay { get; set; }
    
    [Required]
    public decimal TaxAmount { get; set; }
    
    [Required]
    public decimal Deductions { get; set; }
    
    public string? Notes { get; set; }
    
    public virtual Employee Employee { get; set; } = null!;
} 