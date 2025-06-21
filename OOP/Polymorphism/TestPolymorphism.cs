using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.OOP.Polimorphism;
using NUnit.Framework;

namespace ETA25_Intermediate_C_.OOP.Polymorphism;
public class TestPolymorphism
{
    [Test]
    public void TestMethodPolymorphism()
    {
        Student student = new Student("Noemi", "Sz", 55, "UBB", "IT", true);
        student.Eat();

        Person person = new Person("Noe", "Sz", 99);
        person.Eat();
    }

    public int Add(int a, int b)
    {
        return a + b; 
    }

    public int Add(int a, int b, int c)  //method overloading
    {
        return a + b+ c;
    }


    public int Add(double a, double b) 
    {
        return (int)( a + b);
    }

    //polimorphis dinamic

}
