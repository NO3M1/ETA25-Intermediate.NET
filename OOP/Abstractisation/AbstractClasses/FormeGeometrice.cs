using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP.Abstractisation.AbstractClasses;
public abstract class FormeGeometrice
{
    public string Culoare { get; set; }

    public abstract void CalculAria();
    public void Deseneaza()
    {
        Console.WriteLine($"Desenez o forma geometrica");
    }
}
