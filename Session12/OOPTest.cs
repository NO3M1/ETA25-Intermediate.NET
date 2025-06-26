using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ETA25_Intermediate_C_.Session12;
public class OOPTest
{
    [Test]
    public void OOPTestCasa()
    {
        //arrange 
        var living = new Living("Living Room", 30, "Blue", "Sofa", "TV");

        var bucatarie1 = new Bucatarie("Kitchen 1", 20, "White", "Samsung", "Gas");
        var bucatarie2 = new Bucatarie("Kitchen2", 80, "White", "LG", "Gas");

        var casa = new Casa(living, new List<Bucatarie> { bucatarie1, bucatarie2 });

        // act
        casa.PrezentareCasa();


    }
}
