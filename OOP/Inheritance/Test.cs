using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ETA25_Intermediate_C_.OOP.Inheritance
{
    public class Test
    {
        //Inheritance:
        //- conceptul prin care o clasa (copil) mosteneste alta clasa (parinte)
        //- iN C# se poate mosteni doar o singura clasa 
        //- clasa copil preia proprietatile si metodele unei clase parinte

        [Test]
        public void TestMethod()
        {
            var person = new Person("Noemi", 99, 100);
            person.InfoPerson();

            var ion = new Angajat ("Ion", 11, 495, "Tester", 9999, "ECdffd");
            ion.InfoAngajat();
            //ion.InfoPerson();

            var studentIon = new Student("Ion", 33, 189, "UBB", "real", true);
            studentIon.InfoStudent();
            //vizibil metoda studentIon.InfoPerson();


        }
    }
}
