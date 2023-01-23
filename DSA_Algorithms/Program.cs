using static System.Net.Mime.MediaTypeNames;

namespace DSA_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algorithms run = new Algorithms();
            int[] array = { 30, 20, 50, 70, 120, 180, 100, 40 };
            Console.WriteLine("Before Sorting:");
            run.Print(array);
            Console.WriteLine("\nAfter Sorting");
            run.sort(array, 0, array.Length - 1);
            run.Print(array);
        }
    }
}