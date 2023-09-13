namespace HashSetSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("PS4");
            //set.Add("CellPhone");

            //Console.WriteLine(set.Contains("TV"));

            //foreach(string s in set)
            //{
            //    Console.WriteLine(s);
            //}

            SortedSet<int> a = new SortedSet<int> { 1, 2, 3 };
            SortedSet<int> b = new SortedSet<int> { 1, 2, 4, 5, 6 };

            //Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
           
            
        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T item in collection)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}