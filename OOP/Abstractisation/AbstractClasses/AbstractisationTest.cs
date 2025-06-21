using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ETA25_Intermediate_C_.OOP.Abstractisation.AbstractClasses;
public class AbstractisationTest
{
    [Test]
    public void TestMethod()
    {
/*        Cerc cerc = new Cerc();
        cerc.Raza = 5;
        cerc.Culoare = "albastru";*/

        Cerc cerc = new Cerc { Raza = 5, Culoare = "Alb" };

        cerc.CalculAria();
        cerc.Deseneaza();

        Patrat patrat = new Patrat { Latura = 5, Culoare = "Rosu" };

        patrat.CalculAria();
        patrat.Deseneaza();

    }

}

