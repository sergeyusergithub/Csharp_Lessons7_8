using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Kangaroo : Animal
    {
        public int Height { get; set; } 

        public Kangaroo(string name, int height):base(name)
        {
            Height = height;
        }

        public override void Print()
        {
            Console.WriteLine("Kangaroo: " + base.Name + ", he height " + Height);
        }
    }
}
