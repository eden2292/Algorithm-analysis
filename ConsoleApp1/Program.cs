using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //create random number generator for array creation
            Random rand = new Random();

            //create stopwatch for timing.
            Stopwatch stopwatch = new Stopwatch();

            //initialise array
            //increase number to change number of array elements.
            int[] array = new int[10];

            //populate array with random numbers
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100000);
            }

            //copy original array to temporary array to ensure algorithms always run on the same data set
            int[] arr = new int[array.Length];
            Array.Copy(array, arr, array.Length);

            Console.WriteLine("unsorted array:");
            SundryMethods.print(array);

            //run bubble sort multiple times
            for (int i = 0; i < 5; i++)
            {
                SundryMethods.runBubble(arr, stopwatch);
                Array.Copy(array, arr, array.Length);
            }

            //run merge sort multiple times
            for (int i = 0; i < 5; i++)
            {
                SundryMethods.runMerge(arr, stopwatch);
                Array.Copy(array, arr, array.Length);
            }

            //algorithms are run multiple times to get an average.
        }
    }
}