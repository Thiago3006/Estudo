using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoFile.Entities
{
    internal class Produto
    {
        string Name { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }

        public Produto(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double  Total()
        {
            return Quantity* Price;
        }
    }
}
