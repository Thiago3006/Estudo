using System;
using AbstractModel.Entities.Enums;
using AbstractModel.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for( int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nShape #{i} data:");
                Console.Write("Rectangle or Circle(r/c): ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(c == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(color, width, height));
                }
                if(c == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine($"\nSHAPE AREAS:");
            double total = 0;
            foreach(Shape shape in list)

            {
                Console.WriteLine(shape.ToString());
                total += shape.Total();
            }
            Console.WriteLine($"Total area: {total.ToString("F2",CultureInfo.InvariantCulture)}");
            
        }
    }
}
