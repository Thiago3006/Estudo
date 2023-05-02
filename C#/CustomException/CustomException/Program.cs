using CustomException.Entities;
using CustomException.Entities.Exceptions;

namespace CustomException
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

                    Console.Write("Room number: ");
                    int roomNumber = int.Parse(Console.ReadLine());
                    Console.Write("Check-in date (dd/MM/yyyy): ");
                    DateTime checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-out date (dd/MM/yyyy): ");
                    DateTime checkOut = DateTime.Parse(Console.ReadLine());
                    Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                    Console.WriteLine($"Reservation: {reservation}");

                    Console.WriteLine("\nEnter data to update the reservation:");
                    Console.Write("Check-in date: (dd/MM/yyyy): ");
                    checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-out date: (dd/MM/yyyy): ");
                    checkOut = DateTime.Parse(Console.ReadLine());

                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine($"Reservation: {reservation}");
                    Console.Write("\nWhishes insert a new reservation? (y/n) ");
                    q = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (DomainException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    Console.Write("\nWishes remake the reservation? (y/n) ");
                    q = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            } while (q == 'y');
        }
    }
}