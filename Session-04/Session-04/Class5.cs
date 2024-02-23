using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class5
    {
        public Class5()
        {

        }

        public int[] Sort(int[] array)
        {
            // Implementing a simple Bubble Sort Algorithm to sort
            // out array from the lowest to the largest number
            for (int j = array.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }

            return array;
        }
    }
}
