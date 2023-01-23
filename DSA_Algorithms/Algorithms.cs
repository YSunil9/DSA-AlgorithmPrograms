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
        public void InsertionSort(int[] arr)
        {

            int size = arr.Length;
            for (int i = 1; i < size; i++)
            {
                int k = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > k)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = k;
            }
        }
        public void Display(int[] arr)
        {
            Console.WriteLine("The Sorted array is : ");
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }
        //public void binary()
        //{
        //    var text = "An old hawk in the sky";
        //    var word = "hawk";

        //    if (text.Contains(word))
        //    {
        //        Console.WriteLine($"The text contains the {word} word");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The text does not contain the {word} word");
        //    }
        //}

        public void Binary(string input)
        {
            string[] text = System.IO.File.ReadAllLines(@"D:\Bridgelab\repos\DSA_Algorithms\DSA_Algorithms\BinarySearch.txt");
            for (int i = 0; i < text.Length; i++)
            {
                int val = string.Compare(input, text[i]);
                if (val == 0)
                {
                    Console.WriteLine(text[i]);
                    Console.WriteLine("Entered word present on " + i + " index");
                    return;
                }
            }
            Console.WriteLine("Word not present");
            return;
        }
    }
}
