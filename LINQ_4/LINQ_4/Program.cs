using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

class LINQDemo
{
    static void Main()
    {
        Question1(); // LINQ to Array
        Question2(); // LINQ to XML
        Question3(); // LINQ to SQL
        Question4(); // LINQ to Collection
    }

    // a. LINQ to Array
    static void Question1()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers));

        int sum = numbers.Sum();
        Console.WriteLine($"Sum of All Numbers: {sum}");

        int max = numbers.Max();
        int min = numbers.Min();
        Console.WriteLine($"Maximum Number: {max}, Minimum Number: {min}");

        var ascendingOrder = numbers.OrderBy(n => n);
        Console.WriteLine("Sorted in Ascending Order: " + string.Join(", ", ascendingOrder));

        var descendingOrder = numbers.OrderByDescending(n => n);
        Console.WriteLine("Sorted in Descending Order: " + string.Join(", ", descendingOrder));

        int countGreaterThanFive = numbers.Count(n => n > 5);
        Console.WriteLine($"Count of Numbers Greater Than 5: {countGreaterThanFive}");

        var multipliedByTwo = numbers.Select(n => n * 2);
        Console.WriteLine("Numbers Multiplied by 2: " + string.Join(", ", multipliedByTwo));
    }

    // b. LINQ to XML
    static void Question2()
    {
        XElement employees = new XElement("Employees",
            new XElement("Employee",
                new XAttribute("Id", 1),
                new XElement("Name", "John"),
                new XElement("Department", "HR"),
                new XElement("Salary", 5000)
            ),
            new XElement("Employee",
                new XAttribute("Id", 2),
                new XElement("Name", "Alice"),
                new XElement("Department", "IT"),
                new XElement("Salary", 7000)
            ),
            new XElement("Employee",
                new XAttribute("Id", 3),
                new XElement("Name", "Bob"),
                new XElement("Department", "Finance"),
                new XElement("Salary", 6000)
            )
        );

        Console.WriteLine("\nXML Data:");
        Console.WriteLine(employees);

        Console.WriteLine("\nEmployees with Salary > 5500:");
        var highSalaryEmployees = from emp in employees.Elements("Employee")
                                  where (int)emp.Element("Salary") > 5500
                                  select emp;

        foreach (var emp in highSalaryEmployees)
        {
            Console.WriteLine($"Name: {emp.Element("Name").Value}, Department: {emp.Element("Department").Value}, Salary: {emp.Element("Salary").Value}");
        }
    }

    // c. LINQ to SQL (using ADO.NET + LINQ on DataTable)
    public static void Question3()
    {
        string connectionString = "Data Source=LAPTOP-JCML4ATP;Initial Catalog=studentDB;Integrated Security=True";
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT ID, Name, Age FROM student";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            var students = from DataRow row in table.Rows
                           where Convert.ToInt32(row["Age"]) >= 20
                           select new
                           {
                               ID = row["ID"],
                               Name = row["Name"],
                               Age = row["Age"]
                           };

            Console.WriteLine("Students older than 20:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.ID}: {student.Name} - {student.Age} years old");
            }
        }
    }

    // d. LINQ to Collection
    static void Question4()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "Vivek", Department = "Development", Salary = 65000 },
            new Employee { ID = 2, Name = "Nishidh", Department = "Testing", Salary = 55000 },
            new Employee { ID = 3, Name = "Mohan", Department = "Management", Salary = 75000 },
            new Employee { ID = 4, Name = "Kunal", Department = "Support", Salary = 48000 }
        };

        Console.WriteLine("\nAll Employees:");
        var allEmployees = from emp in employees select emp;
        foreach (var emp in allEmployees)
        {
            Console.WriteLine($"{emp.Name} - {emp.Department} - ${emp.Salary}");
        }

        Console.WriteLine("\nEmployees with Salary > 60000:");
        var highSalaryEmployees = employees.Where(emp => emp.Salary > 60000);
        foreach (var emp in highSalaryEmployees)
        {
            Console.WriteLine($"{emp.Name} - {emp.Department} - ${emp.Salary}");
        }

        Console.WriteLine("\nEmployees Grouped by Department:");
        var groupedByDept = employees.GroupBy(emp => emp.Department);
        foreach (var group in groupedByDept)
        {
            Console.WriteLine($"\nDepartment: {group.Key}");
            foreach (var emp in group)
            {
                Console.WriteLine($"{emp.Name} - ${emp.Salary}");
            }
        }

        double avgSalary = employees.Average(emp => emp.Salary);
        Console.WriteLine($"\nAverage Salary: ${avgSalary}");

        Console.WriteLine("\nEmployees Sorted by Salary (Descending):");
        var sortedEmployees = employees.OrderByDescending(emp => emp.Salary);
        foreach (var emp in sortedEmployees)
        {
            Console.WriteLine($"{emp.Name} - {emp.Department} - ${emp.Salary}");
        }
    }
}

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}
