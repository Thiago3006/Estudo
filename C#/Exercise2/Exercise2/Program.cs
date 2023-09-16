using Exercise2.Entities;
using System.Globalization;
namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Full file path: ");

            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] dados = sr.ReadLine().Split(',');
                    string name = dados[0];
                    string email = dados[1];
                    double salary = double.Parse(dados[2],CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter Salary: ");
            double valueSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var maior = list.Where(x => x.Salary > valueSalary).OrderBy(x=> x.Email).Select(x => x.Email);
            Console.WriteLine($"Email of people whose salary is more than: {valueSalary.ToString("F2", CultureInfo.InvariantCulture)}");
            foreach( string m in maior)
            {
                Console.WriteLine(m);
            }

            var sum = list.Where(x => x.Name[0] == 'M').Select(x => x.Salary).Sum();
            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}