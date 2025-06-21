using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP.Abstractisation.AbstractClasses;
public class Cerc : FormeGeometrice
{
    public int Raza {  get; set; } // proprietate
    public override void CalculAria()
    {
        Console.WriteLine($"Aria cercului este egala cu {Math.PI * Math.Pow(Raza,2)}");
    }
}
