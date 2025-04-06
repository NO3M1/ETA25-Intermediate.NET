using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.Session1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age < 0 || age > 150)
                {
                    throw new ArgumentException("The person`s age cannot exceed the specified interval: [0-150]");
                }
                age = value; 
            }
        }
        protected int CNP;


        //constructor1
        public Person()
        {
            //implementtio goes here
            FirstName = "John";
            LastName = "Doe";
            age = 1;

        }

        //constructor2
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            this.age = age;
            
        }

    }



}
