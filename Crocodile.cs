using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Crocodile: Animal
    {
        public string Eats { get; set; }    
        public Crocodile(string name, string eats) : base(name)
        {
            Eats = eats;
        }

        public override void Print()
        {
            Console.WriteLine("Crocodile: " + base.Name + ", he eats " + Eats);
        }
    }
}
