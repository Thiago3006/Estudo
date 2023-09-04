using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosProcess.Entities
{
    internal class contract
    {
        public int ContractNumber { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public List<Installments> Parts { get; set; }


        public contract (int contractnumber, DateTime date, double value)
        {
            ContractNumber = contractnumber;
            Date = date;
            Value = value;
            Parts = new List<Installments>();
        }

        public void AddInstallment(Installments installments)
        {

        }
    }
}
