using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ETA25_Intermediate_C_.OOP
{
    public class CarTest
    {
        [Test]
        public void TestMethod()
        {
            Car car1 = new Car("benzina", "rosu", 5, 1.3);
            car1.DisplayData();

            Console.WriteLine(" ");

            var car2 = new Car("motorina", "alb", 5, 2.3);
            car2.DisplayData();

            Console.WriteLine();

            var car3 = new Car("motorina", "negru", 2, 2.0, "automata");
            car3.DisplayData();

        }

    }
}
