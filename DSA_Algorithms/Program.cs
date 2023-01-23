using static System.Net.Mime.MediaTypeNames;

namespace DSA_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algorithms run = new Algorithms();
                Console.WriteLine("Enter string");
                string input = Console.ReadLine();
                Console.WriteLine("Permutations are");
                run.Permutations(input, 0, input.Length - 1);          
        }
    }
}