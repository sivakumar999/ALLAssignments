using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign17
{
    public class Circle:Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double Area => Math.PI * Radius * Radius;

        public override double Perimeter => 2 * Math.PI * Radius;
    }
}
