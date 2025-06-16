using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP.Abstractisation;
public class Person
{
    private string Nume { get; set; }
    private string Prenume { get; set; }
    private int Varsta { get; set; }

    public Person (string nume, string prenume, int varsta)
    {
        Nume = nume;
        Prenume = prenume;
        Varsta = varsta;
        
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Nume}");
        Console.WriteLine($"LastName: {Prenume}");
        Console.WriteLine($"Age: {Varsta}");
    }
}
