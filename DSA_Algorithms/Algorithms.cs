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
        public void PrimeNumber()
        {
            Console.WriteLine("Enter the Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Numbers between 0 and 1000 are :");
            for (int j = 2; j <= number; j++)
            {
                int count = 0;
                for (int i = 2; i <= j / 2; i++)
                {
                    if ((j % i) == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                    Console.Write(j + " ");
            }
        }
        //MergeSort
        public void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] temp1 = new int[n1];
            int[] temp2 = new int[n2];
            int i, j;

            for (i = 0; i < n1; i++)
            {
                temp1[i] = array[left + i];
            }
            for (j = 0; j < n2; j++)
            {
                temp2[j] = array[middle + 1 + j];
            }
            int k = left;
            i = 0;
            j = 0;

            while (i < n1 && j < n2)
            {
                if (temp1[i] <= temp2[j])
                {
                    array[k] = temp1[i];
                    i++;
                }
                else
                {
                    array[k] = temp2[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                array[k] = temp1[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                array[k] = temp2[j];
                j++;
                k++;
            }
        }
        public void sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                sort(array, left, middle);
                sort(array, 1 + middle, right);

                Merge(array, left, middle, right);
            }
        }
        public void Print(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
