using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.Session12;
public class Bucatarie : Camera, IBucatarie
{
    public string Frigider {  get; set; }
    public string Aragaz {  get; set; }
    public Bucatarie(string Descriere, int Suprafata, string Culoare, string Frigider, string Aragaz) : base(Descriere, Suprafata, Culoare)
    {
        this.Frigider = Frigider;
        this.Aragaz = Aragaz;
    }
    public void PrezentamBucataria()
    {
        PrezentareCamera();
        Console.WriteLine($"Frigider {Frigider}, Aragaz {Aragaz}");
    }
    public void Gatim()
    {
        Console.WriteLine($"Gatim mancare x");
    }

    public void Mancam()
    {
        Console.WriteLine($"Mancarea este gata. Acum mancam");
    }

    public void SpalamVasele()
    {
        Console.WriteLine("Vasele sunt spalate");
    }
}
