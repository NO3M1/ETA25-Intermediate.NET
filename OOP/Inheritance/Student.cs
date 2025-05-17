using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP.Inheritance
{
    public class Student : Person
    {
        public string university;
        public string profile;
        public bool scholarship;

        public Student(string name, int age, double weight, string university, string profile, bool scholarship) : base(name, age, weight)
        {
            this.university = university;
            this.profile = profile; 
            this.scholarship = scholarship;
        }

        public void InfoStudent()
        {
            InfoPerson();
            Console.WriteLine($"University: {university}, profile {profile}, scholarship {scholarship}");
        }
    }
}
