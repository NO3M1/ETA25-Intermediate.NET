using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.Session6;

public class Manager : Person
{
    private int _teamSize;
    private decimal _bonus;

    public Manager(string name, string name2) : base(name)
    {
        
    }

    //encapsulare - Encapsulation is the process of bundling data (variables) and methods (functions) that operate on the data into a single unit, or class.
    //It restricts direct access to some of the object’s components, which can prevent the accidental modification of data. This is achieved using access modifiers such as private, protected, and public.
    //setare getter setter

    public void SetTeamSize(int size)
    {
       
        if (size < 0)
        {
            throw new ArgumentException("The size cannot be < 0");
        }
        _teamSize = size;
    }

    public int GetTeamSize()

    {
        return _teamSize;
    }

    public void SetBonus(decimal amount)
    {
        if ( amount < 0)
        {
            throw new ArgumentException("Amount cannot be <0");
        }
        _bonus = amount;
    }

    public decimal GetBonus()
    {
        return _bonus;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Manager: {Name} ,Leads of{_teamSize} people, Bonus {_bonus} ");
    }

    public override string WoAmI()
    {
        return "I am Manager class";
    }

}


