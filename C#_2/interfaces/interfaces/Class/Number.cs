using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Class
{
    internal class Number : Numbers
    {
        public override void AddNumber(int number)
        {
            Array.Resize(ref ints, ints.Length + 1);
            ints[ints.Length - 1] = number;

            Console.WriteLine("All numbers:");
            foreach (int num in ints)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
