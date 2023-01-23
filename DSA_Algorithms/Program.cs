using static System.Net.Mime.MediaTypeNames;

namespace DSA_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algorithms run = new Algorithms();
            //run.Anagram();
            //run.BubbleSort();
            //InsertionSort insertionSort = new InsertionSort();

            //int[] arr = { 60, 20, 4, 35, 10, 15, 5 };
            //run.InsertionSort(arr);
            //run.Display(arr);

            run.Binary("dhoni");
        }
    }
}