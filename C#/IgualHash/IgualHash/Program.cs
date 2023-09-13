using IgualHash.Entities;
namespace IgualHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("Computer", 1500.0));
            a.Add(new Product("TV", 1000.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(1, 5));


            Product prod = new Product("Computer", 1500.0);
            Console.WriteLine(a.Contains(prod));

            Point c = new Point(3, 4);
            Console.WriteLine(b.Contains(c));

        }
    }
}