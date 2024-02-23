using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class3
    {
        public Class3()
        {

        }

        // Just for implementing more specific accesibility funtionality
        // and making my code more readable
        private bool isPrime(int number)
        {
            bool primeNumber = true;

            // Implementing an algorithm to check if a number is
            // a prime number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if ((number % i == 0) && (number != i))
                {
                    primeNumber = false;
                }
            }

            return primeNumber;
        }

        public void GetPrimeNumbers(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                if (isPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}