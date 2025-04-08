using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Interface - ek contract jaisa hota hai, jisko class ko follow karna padta hai
public interface IPerson
{
    void ShowDetails();
}

// Base class - Person
public class Person : IPerson
{
    public string Name { get; set; } // Person ka naam
    public int Age { get; set; }     // Person ki age

    // Constructor - jab hum object banate hain tab chalta hai
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method - isse child class badal sakti hai (override kar sakti hai)
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    // Interface ka method implement kiya
    public void ShowDetails()
    {
        Console.WriteLine("Person Details Displayed.");
    }
}

// Derived class - Employee, jo Person se inherit karta hai
public class Employee : Person
{
    public int EmployeeId { get; set; }      // Employee ka ID
    public string Department { get; set; }   // Department ka naam

    // Constructor - jab Employee ka object banta hai tab ye chalta hai
    public Employee(string name, int age, int employeeId, string department) : base(name, age)
    {
        EmployeeId = employeeId;
        Department = department;
    }

    // Overriding - base class ka method change kiya
    public override void DisplayInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}, Department: {Department}");
        base.DisplayInfo(); // Base class ka DisplayInfo bhi dikhaya
    }
}

// Static class - jisme sirf static members hote hain
public static class Company
{
    public static string CompanyName { get; } // Read-only property, value change nahi kar sakte

    // Static constructor - program me sirf ek baar chalta hai
    static Company()
    {
        CompanyName = "Tech Solutions Ltd";
        Console.WriteLine("Static Constructor: Company Initialized.");
    }
}

// Program chalane ke liye main class
class Program
{
    static void Main()
    {
        // Company ka naam dikhate hain
        Console.WriteLine($"Welcome to {Company.CompanyName}\n");

        // Person ka object banaya
        Person person = new Person("Mohan", 21);
        person.DisplayInfo(); // Name aur age dikhaya
        person.ShowDetails(); // Interface wala method

        Console.WriteLine();

        // Employee ka object banaya
        Employee employee = new Employee("Saurabh", 28, 1001, "HR");
        employee.DisplayInfo(); // Employee ki full detail
        employee.ShowDetails(); // Interface method jo Person me define kiya tha

        Console.WriteLine();

        // Polymorphism - base class ka reference me child object diya
        Person empAsPerson = new Employee("Vikas", 35, 1002, "IT");
        empAsPerson.DisplayInfo(); // Employee ka DisplayInfo chalega kyunki override kiya tha
    }
}
