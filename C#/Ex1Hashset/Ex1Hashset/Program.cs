using Ex1Hashset.Entities;
namespace Ex1Hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<Log> a = new HashSet<Log>();

            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime date = DateTime.Parse(line[1]);
                        a.Add(new Log(name, date));
                       

                        
                    }

                    Console.WriteLine("Total users: " + a.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}