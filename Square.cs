using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Lessons7_8
{
    public class Square : Geometric
    {
       
            public int A { get; set; }
           
            public Square(int A)
            {
                this.A = A;
            }

            public override double S()
            {
                return A * A;
            }
            public override double P()
            {
                return 4*A;
            }
    }
}
