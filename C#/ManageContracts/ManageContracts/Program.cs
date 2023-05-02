using System;
using ManageContracts.Entities.Enums;
using ManageContracts.Entities;
using System.Globalization;

namespace ManageContracts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter Worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Department department = new Department(dept);
            Worker worker = new Worker(name,level,baseSalary,department);
            Console.WriteLine();
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEnter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                
                HourContract contract = new HourContract(data,valuePerHour, duration);

                worker.AddContract(contract);

            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string yearMonth = Console.ReadLine();
            int month = int.Parse(yearMonth.Substring(0,2));
            int year = int.Parse(yearMonth.Substring(3));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {yearMonth}: {worker.InCome(year, month).ToString("F2",CultureInfo.InvariantCulture)}");



            
        }
    }
}
