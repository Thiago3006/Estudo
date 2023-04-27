using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TaxContribution.Entities
{
    internal class Individual : Texpayer
    {
        public double Health { get; set; }

        public Individual(string name, double annualIncome, double health) : base (name, annualIncome)
        {
            Health = health;
        }

        public override double TexCalculate()
        {
            double tex;
            if (AnnualIncome > 20000)
            {
                tex = (AnnualIncome * 0.25) - (Health * 0.5);
            }
            else
            {
                tex = (AnnualIncome * 0.15) - (Health * 0.5);
            }
            return tex;
        }

        public override string ToString()
        {

            return $"{Name}: ${TexCalculate().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
