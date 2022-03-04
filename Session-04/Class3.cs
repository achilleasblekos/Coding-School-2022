using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class3
    {
        public Class3(){
        }

        
    }



    internal int Finder(int i)
    {
        Console.Write("give an integer to find its prime numbers : ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int k = 1; k <= num; k++)
        {
            int ctr = 0;

            for (int j = 2; j <= k / 2; j++)
            {
                if (k % j == 0)
                {
                    ctr++;
                    break;
                }
            }

            if (ctr == 0 && k != 1)
                Console.WriteLine("{0} ", k);
        }
    }















}
