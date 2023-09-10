using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDoDiamante.Devices
{
    internal class ComboDevice : Device, IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine($"ComboDevice print {document}"); 
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"ComboDevice processing: {document}");
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}


//Criado interfaces para que possa ser usado o mesmo metodo usado na classe 'Printer' e 'Scanner' (ProcessDoc)