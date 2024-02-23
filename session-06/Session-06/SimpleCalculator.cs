using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class SimpleCalculator : Calculator
    {
        public ComputationTypeEnum ComputationType { get; set; }

        public SimpleCalculator()
        {

        }

        public override double? Compute(double? inputA, double? inputB, ComputationTypeEnum computationType)
        {
            Computations.Computation computation = null;

            switch (computationType)
            {
                case ComputationTypeEnum.Addition:
                    computation = new Computations.Addition();
                    break;
                case ComputationTypeEnum.Subtraction:
                    computation = new Computations.Substraction();
                    break;
                case ComputationTypeEnum.Multiplication:
                    computation = new Computations.Multiplication();
                    break;
                case ComputationTypeEnum.Division:
                    computation = new Computations.Division();
                    break;
                case ComputationTypeEnum.Power:
                    computation = new Computations.Power();
                    break;
                case ComputationTypeEnum.SquareRoot:
                    computation = new Computations.SquareRoot();
                    break;
                default:
                    break;
            }

            return computation.Execute(inputA, inputB);
        }
    }
}
