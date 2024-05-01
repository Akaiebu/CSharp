using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_new.classes
{
    internal class Duzbucaq : Figure
    {
        public double A { get; }
        public double B { get; }

        public Duzbucaq(double a, double b)
        {
            A = a;
            B = b;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (A + B);
        }
    }
}
