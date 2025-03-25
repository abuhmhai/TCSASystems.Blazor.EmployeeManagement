using Bogus;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TCSASystems.Blazor.EmployeeManagement.Models;

namespace TCSASystems.Blazor.EmployeeManagement.Data;

public class DataContext : IdentityDbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Attendance> Attendances { get; set; }

    public DataContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var employees = GetEmployees();
        modelBuilder.Entity<Employee>().HasData(employees);

        var attendances = GetAttendances(employees);
        modelBuilder.Entity<Attendance>().HasData(attendances);

        modelBuilder.Entity<Attendance>()
            .HasOne(a => a.Employee)
            .WithMany()
            .HasForeignKey(a => a.EmployeeId);
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

    private List<Attendance> GetAttendances(List<Employee> employees)
    {
        var attendances = new List<Attendance>();
        var random = new Random();

        foreach (var employee in employees)
        {
            for (int i = 0; i < 20; i++)
            {
                DateTime date = DateTime.Today.AddDays(-random.Next(30));
                TimeOnly checkIn = new TimeOnly(random.Next(7, 10), random.Next(0, 60));
                TimeOnly? checkOut = new TimeOnly(random.Next(16, 19), random.Next(0, 60));

                attendances.Add(new Attendance
                {
                    Id = attendances.Count + 1,
                    EmployeeId = employee.Id,
                    Date = date,
                    CheckIn = checkIn,
                    CheckOut = checkOut
                    // Remove HoursWorked and IsLate assignments since they're computed
                });
            }
        }

        return attendances;
    }

    private decimal GetRandomSalary(Random random)
    {
        return random.Next(30000, 100000);
    }

    private EmployeeType GetRandomEmployeeType(Random random)
    {
        var types = Enum.GetValues(typeof(EmployeeType));
        return (EmployeeType)types.GetValue(random.Next(types.Length));
    }

    private Position GetRandomPosition(Random random)
    {
        var positions = Enum.GetValues(typeof(Position));
        return (Position)positions.GetValue(random.Next(positions.Length));
    }
}