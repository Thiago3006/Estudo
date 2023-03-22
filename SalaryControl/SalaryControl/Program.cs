using System;
using System.Collections.Generic;
using System.Globalization;
namespace SalaryControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                
            }

            Console.Write($"\nEnter the employee id that will have salary increase: ");
            int search = int.Parse(Console.ReadLine());
            Employee emp = employees.Find(x => x.Id == search);

            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.SalaryIncrease(perc);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            employees.Sort(delegate (Employee emp1, Employee emp2)
            {
                return emp1.Id.CompareTo(emp2.Id);
            });

            foreach(Employee empl in employees)
            {
                Console.WriteLine(empl);
            }



        }
    }

}

