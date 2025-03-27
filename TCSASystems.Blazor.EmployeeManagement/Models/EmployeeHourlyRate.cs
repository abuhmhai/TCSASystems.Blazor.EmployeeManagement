using TCSASystems.Blazor.EmployeeManagement.Models;

namespace TCSASystems.Blazor.EmployeeManagement.Models;

public static class EmployeeHourlyRate
{
    public static decimal GetRecommendedRate(EmployeeType type, Position position)
    {
        return type switch
        {
            EmployeeType.FullTime => GetFullTimeRate(position),
            EmployeeType.PartTime => GetPartTimeRate(position),
            EmployeeType.Casual => GetCasualRate(position),
            EmployeeType.Freelance => GetFreelanceRate(position),
            _ => 0
        };
    }

    private static decimal GetFullTimeRate(Position position)
    {
        return position switch
        {
            Position.CEO => 150,
            Position.CFO => 140,
            Position.CTO => 140,
            Position.SoftwareEngineer => 85,
            Position.DataAnalyst => 75,
            Position.ProjectManager => 90,
            Position.HRManager => 80,
            Position.AccountManager => 80,
            Position.MarketingManager => 80,
            Position.SalesRepresentative => 70,
            Position.CustomerServiceRepresentative => 60,
            Position.Other => 50,
            _ => 0
        };
    }

    private static decimal GetPartTimeRate(Position position)
    {
        return position switch
        {
            Position.CEO => 160,
            Position.CFO => 150,
            Position.CTO => 150,
            Position.SoftwareEngineer => 95,
            Position.DataAnalyst => 85,
            Position.ProjectManager => 100,
            Position.HRManager => 90,
            Position.AccountManager => 90,
            Position.MarketingManager => 90,
            Position.SalesRepresentative => 80,
            Position.CustomerServiceRepresentative => 70,
            Position.Other => 60,
            _ => 0
        };
    }

    private static decimal GetCasualRate(Position position)
    {
        return position switch
        {
            Position.CEO => 170,
            Position.CFO => 160,
            Position.CTO => 160,
            Position.SoftwareEngineer => 105,
            Position.DataAnalyst => 95,
            Position.ProjectManager => 110,
            Position.HRManager => 100,
            Position.AccountManager => 100,
            Position.MarketingManager => 100,
            Position.SalesRepresentative => 90,
            Position.CustomerServiceRepresentative => 80,
            Position.Other => 70,
            _ => 0
        };
    }

    private static decimal GetFreelanceRate(Position position)
    {
        return position switch
        {
            Position.CEO => 200,
            Position.CFO => 190,
            Position.CTO => 190,
            Position.SoftwareEngineer => 125,
            Position.DataAnalyst => 115,
            Position.ProjectManager => 130,
            Position.HRManager => 120,
            Position.AccountManager => 120,
            Position.MarketingManager => 120,
            Position.SalesRepresentative => 110,
            Position.CustomerServiceRepresentative => 100,
            Position.Other => 90,
            _ => 0
        };
    }
} 