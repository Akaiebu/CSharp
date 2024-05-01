using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Class
{
    internal abstract class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
        public abstract void Drive();
    }
}
