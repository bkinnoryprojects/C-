using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATYAKINNORY_EX05
{
    class Audi : Vehicle
    {
        public Audi() : base("Audi")
        {
        }

        public override void Accelerate()
        {
            // Audi accelerates by 2 km/h instead of 1 km/h
            Speed += 2;
        }
    }

}
