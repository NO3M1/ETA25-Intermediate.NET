using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP.Abstractisation.AbstractClasses;
public class Patrat : FormeGeometrice
{
    public int Latura { get; set; }
    public override void CalculAria()
    {
        Console.WriteLine($"Aria patratului este egala cu {Math.Pow(Latura,2)}");
    }
}
