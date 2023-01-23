using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Algorithms
{
    internal class Algorithms
    {
        public void Permutations(string input, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(input);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    input = ChangePosition(input, left, i);
                    Permutations(input, left + 1, right);
                    input = ChangePosition(input, left, i);
                }
            }
        }
        public string ChangePosition(string input, int left, int right)
        {
            char[] tempString = input.ToCharArray();
            char temp = tempString[left];
            tempString[left] = tempString[right];
            tempString[right] = temp;
            string swapstring = new string(tempString);
            return swapstring;
        }
    }
}
