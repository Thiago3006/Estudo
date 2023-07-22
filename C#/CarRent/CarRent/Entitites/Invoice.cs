using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CarRent.Entitites
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment { get; set; }

        public Invoice (double basicPayment, double tax, double totalPayment)
        {
            BasicPayment = basicPayment;
            Tax = tax;
            TotalPayment = totalPayment;
        }

        public override string ToString()
        {
            return $"Basic Payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTotal Payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
