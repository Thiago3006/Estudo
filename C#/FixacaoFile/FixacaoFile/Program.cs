using FixacaoFile.Entities;
using System;
using System.Globalization;
using System.IO;

namespace FixacaoFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o caminho para o arquivo: ");
            string pasta = Console.ReadLine();



            string[] lines = File.ReadAllLines(pasta);

            string dentroPasta = Path.GetDirectoryName(pasta);
            string novaPasta = dentroPasta + @"\out";
            string novoArquivo = novaPasta + @"\summary.csv";

            Directory.CreateDirectory(novaPasta);

            try
            {


                using (StreamWriter sw = File.AppendText(novoArquivo))
                {
                    foreach (string line in lines)
                    {
                        string[] v = line.Split(',');
                        string name = v[0];
                        double price = double.Parse(v[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(v[2]);

                        Produto produto = new Produto(name, price, quantity);

                        sw.WriteLine($"{name}, {produto.Total().ToString("F2", CultureInfo.InvariantCulture)}");


                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu" + e.Message);
            }
        }


    }
}

