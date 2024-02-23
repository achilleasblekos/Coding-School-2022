using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class1
    {
        public Class1()
        {

        }

        public string ReverseStringIteration(String name)
        {
            string reversedName = "";
            // Iterate throuth the character of a string with the help
            // of a for loop and add to the string the characters from
            // the last place to the first
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversedName += name[i];
            }

            return reversedName;
        }

        public string ReverseStringLibrary(String name)
        {
            // Get the string with the name and reverse it with the help
            // of LINQ Library of .NET
            string reversedName = new String(name.Reverse().ToArray());

            return reversedName;
        }

    }
}
