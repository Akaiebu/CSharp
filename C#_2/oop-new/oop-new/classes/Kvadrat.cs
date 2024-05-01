using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_new.classes
{
    internal class Kvadrat : Figure
    {
        public double A { get; }

        public Kvadrat(double a)
        {
            A = a;
        }
        public override double CalculatePerimeter()
        {
            return 4 * A;
        }
    }
}
