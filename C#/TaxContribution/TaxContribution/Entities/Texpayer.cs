using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxContribution.Entities
{
     abstract class Texpayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Texpayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        abstract public double TexCalculate();

        public abstract string ToString();
        
    }

}
