using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP.Inheritance
{
    public class Person
    {
        public string name;
        public int age;
        public double weight;

        public Person(string name, int age, double weight)
        {
            this.name = name;
            this.age = age; 
            this.weight = weight;   
        }

        public void InfoPerson()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
        }

    }


}
