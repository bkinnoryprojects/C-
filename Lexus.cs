using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATYAKINNORY_EX05
{
    class Lexus : Vehicle
    {
        public bool IsPlaying { get; private set; }

        public Lexus() : base("Lexus")
        {
            IsPlaying = false;
        }

        public void StartPlayingSongs()
        {
            IsPlaying = true;
            Console.WriteLine($"{Type} is playing songs.");
        }

        public void StopPlayingSongs()
        {
            IsPlaying = false;
            Console.WriteLine($"{Type} stopped playing songs.");
        }
    }

}
