using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Lessons7_8
{
    internal class ForeignPassport : Passport
    {
        public ForeignPassport(int id,string name,string country,int age,string visa) : base(id, name, country, age)
        {
            Visa = visa;
        }
        public int Id { get; set; }
        public string Visa {  get; set; }

        public override void Print(string passport)
        {
            base.Print(passport);
            Console.WriteLine($"Visa: {Visa}");
        }

    }
}
