using ETA25_Intermediate_C_.Session1;
using ETA25_Intermediate_C_.Session6;

namespace ETA25_Intermediate_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Session1

            Session1.Person person = new Session1.Person();

            var years = EmployeeUtilities.CalculateSeniorityInYears(DateTime.Now.AddYears(-10));

            Session1.Person person2 = new Session1.Person();
            Console.WriteLine($"The person's first name is {person2.FirstName}, last name is {person2.LastName} and age is {person2.Age}");

            Session1.Person person3 = new Session1.Person("Radu", "Fifiita", 32);
            Console.WriteLine($"The person's first name is {person3.FirstName}, last name is {person3.LastName} and age is {person3.Age}");

            Session1.Person person4 = new Session1.Person("Test", "Boundary", 5);
            Console.WriteLine($"The person's first name is {person4.FirstName}, last name is {person4.LastName} and age is {person4.Age}");

            person4.Age = -1;

            // session1 Homework

            Session1.Person personHomework = new Session1.Person();
            //Person personHomework = new Person("Noemi", "Homework", 55);


            personHomework.FirstName = "Noemi";
            personHomework.LastName = "Homework";
            personHomework.Age = 55;

            Console.WriteLine($"The person`s first name is: {personHomework.FirstName}, last name is {personHomework.LastName} and age is {personHomework.Age}");




            #endregion


            #region Session06

            Session6.Employee employee1 = new Session6.Employee("Noemi", "Testing");
            Console.WriteLine();
            Console.WriteLine();

            employee1.DisplayInfo();
            Console.WriteLine(employee1.WoAmI());

            Console.WriteLine("The current salary is: " + employee1.GetSalary()); //0
            employee1.SetSalary(5000);
            Console.WriteLine("The current salary is: " + employee1.GetSalary()); //5000
            employee1.SetSalary(10000);

            Session6.Person person5 = new Session6.Employee("DerivedClass", "Department");
            person5.DisplayInfo();

            List<Session6.Person> personsList = new List<Session6.Person>()
            {
                new Session6.Employee("Emp1", "Dept1"),
                new Session6.Employee("Emp2", "Dept1"),
                new Session6.Employee("Emp3", "Dept1"),

            };

            personsList.ForEach(person => person.DisplayInfo());

            //HOMEWORK

            //cream manager1
            Session6.Manager manager1 = new Session6.Manager("Noemi", "Sz");
            manager1.SetBonus(10000);
            manager1.SetTeamSize(25);

            //cream employee
            Session6.Employee employeehomework = new Session6.Employee("EmployeeNr1", "Department1");
            employeehomework.SetSalary(598);
            


            //polimorphism

            List<Session6.Person> people = new List<Session6.Person>();
            {

                people.Add(manager1);
                people.Add(employeehomework);

            }

            //foreach (Session6.Person pers in people)
            //{
            //    pers.DisplayInfo();
            //}

            people.ForEach(person => person.DisplayInfo());

            #endregion

            Console.ReadKey();
        }
    }
}

