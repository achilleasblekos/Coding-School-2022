using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public abstract class Calculator
    {
        public Calculator()
        {

        }

        public abstract double? Compute(double? inputA, double? inputB, ComputationTypeEnum computationType);
    }
}
