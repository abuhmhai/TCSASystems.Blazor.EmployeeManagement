using System.ComponentModel.DataAnnotations;

namespace TCSASystems.Blazor.EmployeeManagement.Models
{
    public class AddEmployeeForm
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        public EmployeeType Type { get; set; }

        [Required]
        public Position Position { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Hourly Rate must be between 0 and 1000")]
        public decimal? HourlyRate { get; set; }

        public decimal? Salary { get; set; }

        public string? ImgUrl { get; set; }
    }
} 