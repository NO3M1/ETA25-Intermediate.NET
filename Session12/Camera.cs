using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.Session12;
public class Camera
{
    public string Descriere {  get; set; }  
    public int Suprafata { get; set; }
    public string Culoare { get; set; }
    public Camera(string Descriere, int Suprafata, string Culoare)
    {
        this.Descriere = Descriere;
        this.Suprafata = Suprafata;
        this.Culoare = Culoare;
    }

    public void PrezentareCamera()
    {
        Console.WriteLine($"Descriere {Descriere}, Suprafata {Suprafata}, Culoare {Culoare}");
    }
}
