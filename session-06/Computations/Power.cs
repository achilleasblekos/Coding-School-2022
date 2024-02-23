using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computations
{
    public class Power : Computation
    {
        public Power()
        {

        }

        public override double? Execute(double? inputA, double? inputB)
        {
            if (inputA == null)
            {
                return inputB;
            }

            return Math.Pow(Convert.ToDouble(inputA), Convert.ToDouble(inputB));
        }
    }
}
