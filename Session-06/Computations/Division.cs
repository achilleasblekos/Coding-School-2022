using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computations
{
    public class Division : Computation
    {
        public Division()
        {

        }

        public override double? Execute(double? inputA, double? inputB)
        {
            if (inputA == null)
            {
                return inputB;
            }

            try
            {
                return inputA / inputB;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
