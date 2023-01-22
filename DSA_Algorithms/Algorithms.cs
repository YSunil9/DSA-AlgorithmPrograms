﻿using System;
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
            string string1 = new string(firstValue);
            string string2 = new string(secondValue);

            if (string1 == string2)
            {
                Console.WriteLine("Strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Strings are not Anagrams");
            }
        }
        public void BubbleSort()
        {
            int[] arr = new int[6] { 2, 8, 9, 0, 6, 7 };
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0},", arr[i]);
            }
        }
    }
}
