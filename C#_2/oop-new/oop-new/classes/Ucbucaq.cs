using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_new.classes
{
    internal class Ucbucaq : Figure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Ucbucaq(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double CalculatePerimeter()
        {
            return A + B + C;
        }
    }
}
