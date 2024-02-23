using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class2
    {
        public Class2()
        {

        }

        public int GetSum(int number)
        {
            int sum = 0;

            for (int i = 1; i < number + 1; i++)
            {
                sum += i;
            }

            return sum;
        }

        public int GetProduct(int number)
        {
            int product = 1;

            for (int i = 1; i < number + 1; i++)
            {
                product *= i;
            }

            return product;
        }
    }
}
