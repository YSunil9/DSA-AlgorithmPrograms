using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Algorithms
{
    internal class Algorithms
    {
        public void Anagram()
        {
            Console.WriteLine("Enter first String");
            string value1 = Console.ReadLine();
            Console.WriteLine("Enter second String");
            string value2 = Console.ReadLine();
            char[] firstValue = value1.ToLower().ToCharArray();
            char[] secondValue = value2.ToLower().ToCharArray();
            //string string1 = new string(firstValue);
            //string string2 = new string(secondValue);

            //if (string1 == string2)
            if(firstValue.Length == secondValue.Length)
            {
                Console.WriteLine("Strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Strings are not Anagrams");
            }
        }
    }
}
