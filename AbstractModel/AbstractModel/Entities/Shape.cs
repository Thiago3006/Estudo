using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractModel.Entities.Enums;

namespace AbstractModel.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }
        public Shape() { }
        public Shape(Color color)
        {
            Color = color;
        }
        abstract  public double Area();

        
        public double Total()
        {
            double total = 0;
            return total += Area();
        }
        
        abstract public string ToString();
        
        
    }
}
