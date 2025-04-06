using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V133.CSS;

namespace ETA25_Intermediate_C_.Session1
{
    public class HomeworkPerson
    {
        // private fields
        private string firstName;
        private string lastName;

        //protected field
        protected int age;

        //public properties to get and set ‘first name’ and ‘last name’
        public string FirstName
        { 
        get { return firstName; }
        set { firstName = value; }
        }     
        public string LastName
        { 
        get { return lastName; }
        set { lastName = value; }
        }

        //public method to get the full name of the person
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        //public method to set the age of the person
        public void GetAge(int age)
        {
            this.age = age; 
        }


    }
}
