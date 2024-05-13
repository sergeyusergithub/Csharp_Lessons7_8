using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo;

namespace Zoo
{
    internal class Tiger : Animal
    {
        public int Speed { get; set; }
        public Tiger(string name, int speed):base(name) { 
            Speed = speed;
        }

        public override void Print()
        {
            Console.WriteLine("Tiger: " + base.Name + ", speed: " + Speed);
        }
    }
}
