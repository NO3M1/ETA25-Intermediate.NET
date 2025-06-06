﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.Session6;

public class Employee : Person
{
    public int EmployeeId {  get; set; }
    public string Department { get; set; }
    private decimal _salary;
    private readonly decimal MaxSalaryValue = 10000;

    public Employee(string name, string department) : base(name)
    {
        EmployeeId = new Random().Next();
        Department = department;
        
        
    }

    public override void DisplayInfo() //ovveride suprascrie comportamentul de baza 
    {
        Console.WriteLine($"The employee info is : \n"
            + $"Name: {Name}\n" + 
            $"Employee Id: {EmployeeId}\n" +
            $"Department: {Department}");



    }

    public override string WoAmI()
    {
        return "I am Employee class";
    }

    public decimal GetSalary()
    {
        return _salary;
    }
    public void SetSalary (decimal salary)
    {
        if (salary < 0 || salary > MaxSalaryValue)
        {
            throw new ArgumentException($"The salary values must be within the valid range of [0 - {MaxSalaryValue}].");
        }
        _salary = salary;
    }


}
