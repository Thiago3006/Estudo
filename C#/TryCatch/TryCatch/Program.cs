using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine(a / b);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("It is not divisible by zero!");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Icorrect Format!" + e.Message);
            }

        }
    }
}
