using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATYAKINNORY_EX05
{
    class Vehicle
    {
        public string Type { get; protected set; }
        public int Speed { get; protected set; }

        public Vehicle(string type)
        {
            Type = type;
            Speed = 0;
        }

        public void DisplaySpeed()
        {
            Console.WriteLine($"{Type} Speed: {Speed} km/h");
        }

        public virtual void Accelerate()
        {
            Speed++;
        }

        public void Decelerate()
        {
            if (Speed > 0)
                Speed--;
        }

        public void Stop()
        {
            Speed = 0;
        }
    }

}
