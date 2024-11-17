using System;
using System.Collections.Generic;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return "Employee ID: " + Id + ", Name: " + Name;
    }
}

public class Club
{
    private List<Employee> clubMembers = new List<Employee>();

    public void AddInClub(Employee emp)
    {
        clubMembers.Add(emp);
        Console.WriteLine(emp.Name + " has been added to the club.");
    }
}

public class SocialInsurance
{
    private List<Employee> insuredEmployees = new List<Employee>();

    public void BeginSocialInsurance(Employee emp)
    {
        insuredEmployees.Add(emp);
        Console.WriteLine(emp.Name + " has been enrolled in social insurance.");
    }
}

public class Company
{
    private List<Employee> employees = new List<Employee>();
    private Club c = new Club();
    private SocialInsurance socialIns = new SocialInsurance();

    public void Add(Employee emp)
    {
        employees.Add(emp);
        Console.WriteLine(emp.Name + " has been added to the company.");

        c.AddInClub(emp);
        socialIns.BeginSocialInsurance(emp);
    }

    public void DisplayEmployees()
    {
        Console.WriteLine("Employees in the company:");
        foreach (var emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Company company = new Company();

        Employee emp1 = new Employee(1, "samer");
        Employee emp2 = new Employee(2, "sawiers");

        company.Add(emp1);
        company.Add(emp2);

        Console.WriteLine();
        company.DisplayEmployees();
    }
}