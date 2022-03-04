using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class1
    {

        public Class1(){
        } 
        






        public string ReverseString(string s)
        {
            string str, str1 =string.Empty;
            int i, l;
            str = "achilleas blekos";

            l = str.Length - 1;
            for (i = l; i >= 0; i--)
            {
                str1 = str1 + str[i];
            }
            Console.WriteLine("The string in Reverse  Order Is : {0}", str1);



            return s;   
        }
    }








}
