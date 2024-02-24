using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computations
{
    public class Multiplication : Computation
    {
        public Multiplication()
        {

        }

        public override double? Execute(double? inputA, double? inputB)
        {
            if (inputA == null)
            {
                return inputB;
            }
            return inputA * inputB;
        }

    }
}
