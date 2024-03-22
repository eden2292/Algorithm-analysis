using System.Diagnostics;

namespace ConsoleApp1
{
    internal class SundryMethods
    {
        //method to print array elements.
        public static void print(int[] a)
        {
            foreach (int num in a)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        //method to calculate amount of time taken in milliseconds
        public static void timeCalc(Stopwatch stopwatch)
        {
            //get number of ticks elapsed while algorithm is running
            long ticks = stopwatch.ElapsedTicks;
            //find the frequency of ticks (this differs from pc to pc)
            long frequency = Stopwatch.Frequency;

            //calculate time in milliseconds
            double timeTaken = ((double)ticks / frequency) * 1000;

            //print the time taken
            Console.WriteLine("Time taken = " + timeTaken);
        }

        // method to run bubble sort and measure time taken.
        public static void runBubble(int[] arr, Stopwatch stopwatch)
        {
            stopwatch.Start();
            Algorithms.bubbleSort(arr);
            stopwatch.Stop();
            Console.WriteLine("bubble sort");
            timeCalc(stopwatch);
            stopwatch.Reset();
        }

        //method to run merge sort and measure time taken.
        public static void runMerge(int[] arr, Stopwatch stopwatch)
        {
            stopwatch.Start();
            Algorithms.mergeSort(arr, 0, arr.Length - 1);
            stopwatch.Stop();
            Console.WriteLine("merge sort");
            timeCalc(stopwatch);
            stopwatch.Reset();
        }
    }
}