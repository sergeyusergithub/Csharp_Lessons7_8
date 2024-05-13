using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Lessons7_8
{
    public class Rectangle : Geometric
    {

        public int A { get; set; }
        public int B { get; set; }
        

        public Rectangle(int A, int B)
        {
            this.A = A;
            this.B = B;
        }

        public override double S()
        {
            return A * B;
        }
        public override double P()
        {
            return 2 * (A+B);
        }
    }
}
