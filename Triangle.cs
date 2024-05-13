using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Lessons7_8
{
    public class Triangle: Geometric
    {
        public int A {  get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle(int A, int B, int C) { 
            this.A = A; 
            this.B = B; 
            this.C = C;
        }

        public override double S()
        {
            return Math.Sqrt(P()/2*(P()/2 - A) *(P() / 2 - B) * (P() / 2 - C));
        }
        public override double P()
        {
            return A + B + C;
        }
    }
}
