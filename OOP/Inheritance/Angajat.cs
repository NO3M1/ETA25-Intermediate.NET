using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP.Inheritance
{
    public class Angajat : Person
    {
        public string job;
        public double salary;
        public string employer;

        //contructor
        public Angajat(string name, int age, int weight, string job, double salary, string employer) : base(name, age, weight)
        {
            this.job = job;
            this.salary = salary;
            this.employer = employer;

        }
       
        public void InfoAngajat()
        {
            InfoPerson();
            Console.WriteLine($"Job is {job}");
            Console.WriteLine($"Salary is {salary}");
            Console.WriteLine($"Employer is {employer}");


        }
    }
}
