using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP
{
    public class Car
    {
        string engine;
        string colour;
        int doors;
        double cilinders;
        string gearboxType;

        //constructor = trebuie sa aiba acelasi nume cu clasa noastra + ii dam parametri
        public Car(string engine, string colour, int doors, double cilinders)
        {
            this.engine = engine;
            this.colour = colour;
            this.doors = doors; 
            this.cilinders = cilinders; 
        }

        //constructor
        public Car(string engine, string colour, int doors, double cilinders, string gearboxType)
        {
            this.engine = engine;
            this.colour = colour;
            this.doors = doors;
            this.cilinders = cilinders;
            this.gearboxType = gearboxType;
        }


        //metoda
        public void DisplayData()
        {
            Console.WriteLine($"The engine is {engine}");
            Console.WriteLine($"The colour is {colour}");
            Console.WriteLine($"Number of doors is {doors}");
            Console.WriteLine($"The cilinders: {cilinders}");

            if (gearboxType != null)
            {
                Console.WriteLine($"Gearboxtype is : {gearboxType}");
            }
        }


    }
}
