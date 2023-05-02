using System;
using TaxContribution.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace TaxContribution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Texpayer> list = new List<Texpayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char q = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: $");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (q == 'i')
                {
                    Console.Write("Health expenditures: $");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, annualIncome, health));
                }
                if (q == 'c')
                {
                    Console.Write("Number of employess: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, annualIncome, employees));
                }
            }

            Console.WriteLine("\nTAXES PAID:");

            double total = 0;
            foreach (Texpayer texpayer in list)
            {
                Console.WriteLine(texpayer.ToString());
                total += texpayer.TexCalculate();
            }


            Console.WriteLine($"\nTOTAL TAXES: ${total.ToString("F2",CultureInfo.InvariantCulture)}");

            

        }
    }
}
