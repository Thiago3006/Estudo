using ServicesAccount.Entities;
using ServicesAccount.Entities.Exceptions;
using System.Globalization;

namespace ServicesAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char q = 'a';
            do
            {

                try
                {

                    Console.WriteLine("\nEnter account data: ");
                    Console.Write("Number: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("Holder: ");
                    string holder = Console.ReadLine();
                    Console.Write("Initial Balance: ");
                    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("WithDraw limit: ");
                    double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                    
                    Account account = new Account(number, holder, balance, withDraw);

                    Console.Write("\nEnter amount for withdraw: ");
                    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    account.WithDraw(amount);

                    Console.WriteLine($"New Balance: {account}");
                    Console.Write("\nWishes insert new datas (y/n)? ");
                    q = char.Parse(Console.ReadLine());
                }
                catch (DomainException e)
                {
                    Console.WriteLine($"Withdraw error: {e.Message}");
                    Console.Write("\nWishes insert new datas (y/n)? ");
                    q = char.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    Console.Write($"\nWishes remake (y/n)? ");
                    q = char.Parse(Console.ReadLine());
                }

            } while (q == 'y');

            Console.WriteLine("Finalized!!");
        }
    }
}