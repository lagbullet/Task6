using System;
using System.Collections.Generic;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>
            {
                new Employee("Surname3", "FirstName3", "Patronymic3", "2000-01-01", 500),
                new Employee("Surname1", "FirstName1", "Patronymic1", "2001-01-01", 350),
                new Employee("Surname2", "FirstName2", "Patronymic2", "2002-01-01", 550),
                new Employee("Surname0", "FirstName0", "Patronymic0", "1995-01-01", 400)
            };
            Employees.Sort(new PInfoCompare());
            foreach (Employee empl in Employees)
            {
                Console.WriteLine("Employee");
                Console.WriteLine(empl.ToString());
                Console.WriteLine();
            }
            Console.ReadKey();
            Employees.Sort();
            foreach (Employee empl in Employees)
            {
                Console.WriteLine("Employee");
                Console.WriteLine(empl.ToString());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
