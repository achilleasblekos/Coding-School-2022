using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class4
    {
        public Class4()
        {

        }

        public int[] ArrayMultiplication(int[] array1, int[] array2)
        {
            int[] resultArray = new int[array1.Length * array2.Length];
            int index = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    resultArray[index] = array1[i] * array2[j];
                    index++;
                }
            }

            return resultArray;
        }
    }
}
