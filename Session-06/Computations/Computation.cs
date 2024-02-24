namespace Computations
{
    public abstract class Computation
    {
        public Computation()
        {

        }

        public abstract double? Execute(double? inputA, double? inputB);
    }
}