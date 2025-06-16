using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP.Abstractisation;
public class EmployeeStudent : Person, IStudent, IEmployee
{
    private string Company {  get; set; }
    private double Salary { get; set; }
    private string University {  get; set; }
    private string Profile { get; set; }

    public EmployeeStudent(string nume, string prenume, int varsta, string company, double salary, string university, string profile) : base(nume, prenume, varsta)
    {
        Company = company;
        Salary = salary;
        University = university;
        Profile = profile;  
    }

    public void GoToWork()
    {
        Console.WriteLine("Employee student is going to work ");
    }

    public void TakeBreak()
    {
        Console.WriteLine($"Employee student  is taking a break");
    }
    public void AttendMeeting()
    {
        Console.WriteLine($"Employee student  is attending a meeting");
    }
    public void Study()
    {
        Console.WriteLine("The employee student is studying");
    }
    public void AttendClass()
    {
        Console.WriteLine("The employee student is studying");
    }
    public void TakeExam()
    {
        Console.WriteLine("The employee student is studying");
    }
}

