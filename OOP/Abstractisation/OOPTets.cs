using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ETA25_Intermediate_C_.OOP.Abstractisation;
internal class OOPTets
{
    [Test]
    public void Test()
    {
        Employee employee = new Employee("Noemi", "Sz", 99, "IT", 999999);
        employee.GoToWork();
        employee.TakeBreak();

        EmployeeStudent employeeStudent = new EmployeeStudent("Noe", "Sz", 99, "Test", 55, "UBB", "Real");
        employeeStudent.GoToWork();
        employeeStudent.Study();
    }

}
