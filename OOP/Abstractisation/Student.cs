using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP.Abstractisation;
public class Student : Person, IStudent
{
    private string University {  get; set; }
    private string Profile { get; set; }
    private bool HaveScholarship { get; set; }

    public Student(string nume, string prenume, int varsta, string university, string profile, bool scholarship) : base (nume, prenume, varsta)
    {
        University = university;
        Profile = profile;
        HaveScholarship = scholarship;
    }

    public void Study()
    {
        Console.WriteLine("The student is studying");
    }
    public void AttendClass()
    {
        Console.WriteLine("The student is studying");
    }
    public void TakeExam()
    {
        Console.WriteLine("The student is studying");
    }

}
