using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Lessons7_8
{
    internal class Passport
    {
        public Passport(int id, string name, string country, int age) { 
            Id = id;
            Name = name;
            Country = country;
            Age = age;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public virtual void Print(string passport)
        {
            Console.WriteLine($"{passport}:\nId: {Id}\nName: {Name}\nCountry: {Country}\nAge: {Age}");
        }
    }
}
