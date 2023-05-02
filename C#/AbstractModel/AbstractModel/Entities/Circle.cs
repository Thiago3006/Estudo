using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractModel.Entities.Enums;
using System.Globalization;

namespace AbstractModel.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }
        public Circle(Color color, double radius): base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Area circle: {Area().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
