using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.Session12;
public class Casa
{
    //casa trebuie sa contina anumita aspecte 
    //proprietate -obiect living
    public Living Living { get; set; }
    public List<Bucatarie> Bucatarii { get; set; }

    public Casa(Living living, List<Bucatarie> bucatarii)
    {
        Living = living;
        Bucatarii = bucatarii;
    }

    public void PrezentareCasa()
    {
        Console.WriteLine("Prezentarea casei");
        Living.PrezentareLiving();
        foreach (var bucatarie in Bucatarii)
        {
            bucatarie.PrezentamBucataria();
        }
    }

}
