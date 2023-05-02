using System;
using System.Collections.Generic;
using ControlPayment.Entities;
using System.Globalization;

namespace ControlPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i} data:");
                Console.Write("OutSourced (y/n): ");
                char q = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (q == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addval = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, value, addval));
                }
                if (q == 'n')
                {
                    list.Add(new Employee(name, hours, value));
                }

            }

            Console.WriteLine($"\nPAYMENTS:");
            foreach (Employee e in list)
            {
                Console.Write(e);
            }
        }
    }
}
