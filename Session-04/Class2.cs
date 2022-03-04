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



        public int GetProduct(int i)
        {
            int n;
            //Console.WriteLine("Please enter a number to get its factorial: ");
            //num = Convert.ToInt32(Console.ReadLine());

            n = i; 

            while (i > 0)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    n *= i;
                }
                //Console.WriteLine("Factorial of {0}! = {1}\n", num, n);
                i--;
            }
            return i;

          
        }







        public int GetSum(int i)
        {
            int sum = 0;
            for (int x = 1; x <= i; x++)
                sum += i;

            return sum;
        }
    }

    }


