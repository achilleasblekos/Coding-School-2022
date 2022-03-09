

namespace Calculator
{
    

    public class Calc
    {
       

        public Calc()
        {

        }

        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = AddNumbers(num1, num2);
                    break;
                case "s":
                    result = SubNumbers(num1, num2);
                    break;
                case "m":
                    result = MultNumbers(num1, num2);
                    break;
                case "d":
                    
                    result = DivNumbers(num1, num2);
                    break;
                
                default:
                    break;
            }
            return result;
        }

        private double DivNumbers(double num1, double num2)
        {
            throw new NotImplementedException();
        }

        private double MultNumbers(double num1, double num2)
        {
            throw new NotImplementedException();
        }

        private double SubNumbers(double num1, double num2)
        {
            throw new NotImplementedException();
        }

        private double AddNumbers(double num1, double num2)
        {
            throw new NotImplementedException();
        }
    }
}





