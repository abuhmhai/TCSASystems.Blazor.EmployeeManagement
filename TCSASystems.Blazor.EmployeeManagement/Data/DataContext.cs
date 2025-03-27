using Bogus;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TCSASystems.Blazor.EmployeeManagement.Models;

namespace TCSASystems.Blazor.EmployeeManagement.Data;

public class DataContext : IdentityDbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<Attendance> Attendances { get; set; } = null!;
    public DbSet<Payroll> Payrolls { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>()
            .HasMany(e => e.Attendances)
            .WithOne(a => a.Employee)
            .HasForeignKey(a => a.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Employee>()
            .HasMany(e => e.Payrolls)
            .WithOne(p => p.Employee)
            .HasForeignKey(p => p.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        // Seed data
        var employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John Doe",
                ImgUrl = "https://example.com/john.jpg",
                Salary = 100000,
                HourlyRate = 50,
                Type = EmployeeType.FullTime,
                Position = Position.SoftwareEngineer
            },
            new Employee
            {
                Id = 2,
                Name = "Jane Smith",
                ImgUrl = "https://example.com/jane.jpg",
                Salary = 90000,
                HourlyRate = 45,
                Type = EmployeeType.FullTime,
                Position = Position.DataAnalyst
            }
        };

        var attendances = new List<Attendance>
        {
            new Attendance
            {
                Id = 1,
                EmployeeId = 1,
                Date = DateTime.Today,
                CheckIn = new TimeOnly(9, 0),
                CheckOut = new TimeOnly(17, 0)
            },
            new Attendance
            {
                Id = 2,
                EmployeeId = 2,
                Date = DateTime.Today,
                CheckIn = new TimeOnly(9, 0),
                CheckOut = new TimeOnly(17, 0)
            }
        };

        modelBuilder.Entity<Employee>().HasData(employees);
        modelBuilder.Entity<Attendance>().HasData(attendances);
    }

    private List<Employee> GetEmployees()
    {
        var employees = new List<Employee>();
        var faker = new Faker("en");
        var random = new Random();

        for (int i = 1; i <= 50; i++)
        {
            var employee = new Employee
            {
                Id = i,
                ImgUrl = faker.Internet.Avatar(),
                Name = faker.Name.FullName(),
                Salary = GetRandomSalary(random),
                Type = GetRandomEmployeeType(random),
                Position = GetRandomPosition(random)
            };

            employees.Add(employee);
        }

        return employees;
    }

    private decimal GetRandomSalary(Random random)
    {
        return random.Next(30000, 150000);
    }

    private EmployeeType GetRandomEmployeeType(Random random)
    {
        var types = Enum.GetValues(typeof(EmployeeType));
        return (EmployeeType)types.GetValue(random.Next(types.Length))!;
    }

    private Position GetRandomPosition(Random random)
    {
        var positions = Enum.GetValues(typeof(Position));
        return (Position)positions.GetValue(random.Next(positions.Length))!;
    }
}