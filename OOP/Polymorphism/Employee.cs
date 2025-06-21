using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP.Polimorphism;
public class Employee : Person
{
    private string Company { get; set; }
    private double Salary { get; set; }

    public Employee(string nume, string prenume, int varsta, string company, double salary) : base(nume, prenume, varsta)
    {
        Company = company;
        Salary = salary;
    }
    public void DisplayEmployeeInfo()
    {
        DisplayEmployeeInfo();
        Console.WriteLine($"Company: {Company}");
        Console.WriteLine($"Salary:{Salary}");
    }

    public void GoToWork()
    {
        Console.WriteLine("Employee is going to work ");
    }

    public void TakeBreak()
    {
        Console.WriteLine($"Employee is taking a break");
    }
    public void AttendMeeting()
    {
        Console.WriteLine($"Employee is attending a meeting");
    }

}
