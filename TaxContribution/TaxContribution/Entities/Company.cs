using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TaxContribution.Entities
{
    internal class Company : Texpayer

    {
        public int Employees { get; set; }

        public Company(string name, double annualIncome, int employess) : base(name, annualIncome)
        {
            Employees = employess;
        }

        public override double TexCalculate()
        {
            double tex;
            if (Employees > 10)
            {
                tex = AnnualIncome * 0.14;
            }
            else
            {
                tex = AnnualIncome * 0.16;
            }
            return tex;
        }
        public override string ToString()
        {
            return $"{Name}: ${TexCalculate().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
