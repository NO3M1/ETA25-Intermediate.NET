using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.Session6;

public abstract class Person 
    //clasele de baza sunt declarateabstracte
    // nu e obligatoriu ca o clasa abstracta sa aiba doar metode abstracte
{
    public string Name { get; set; }

    protected Person(string name)
    {
        Name = name;
    }
    public abstract void DisplayInfo();
  

    public virtual string WoAmI()
    {
        return "I am base class";

    }


 
}

