using ProblemaDoDiamante.Devices;

namespace ProblemaDoDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");


            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("An Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 1023 };
            c.ProcessDoc("ComboDevice");
            c.Print("ComboDevice");
            Console.WriteLine(c.Scan());
        }
    }
}