using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.Session12;
public class Living : Camera, ILiving
{
    public string Televizor {  get; set; }
    public string Canapea   { get; set; }

    public Living(string Descriere, int Suprafata, string Culoare, string Televizor, string Canapea) : base(Descriere, Suprafata, Culoare)
    {
        this.Canapea = Canapea;
        this.Televizor  = Televizor;
    }
    public void PrezentareLiving()
    {
        PrezentareCamera();
        Console.WriteLine($"Televizor {Televizor}, Canapea {Canapea}");
    }

    public void PrimireMusafiri()
    {
        Console.WriteLine("Musafiri sunt bine veniti in living"); 
    }

    public void VizionareFilm()
    {
        Console.WriteLine("Vizionare filme in curs");
    }
}

