using System.Diagnostics;

//Method for bubble sort
static void bubbleSort(int[] arr)
{
    int n = arr.Length;

    //nested loops to iterate through the array
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            //comparison of elements
            if (arr[j] > arr[j + 1])
            {
                //swap elements if needed, using a temporary variable
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

// method for merge sort
static void mergeSort(int[] arr, int left, int right)
{
    //check if the array contains more than one element
    if (left < right)
    {
        //find the middle element
        int middle = left + (right - left) / 2;

        //recursively call merge sort on each half of the array to divide it further
        mergeSort(arr, left, middle);
        mergeSort(arr, middle + 1, right);

        //merge the halves once they have been sorted.
        merge(arr, left, middle, right);
    }
}

// method for merge.
static void merge(int[] arr, int left, int middle, int right)
{
    //find sizes of subarrays
    int n = middle - left + 1;
    int m = right - middle;

    //create temporary arrays
    int[] leftTemp = new int[n];
    int[] rightTemp = new int[m];

    //counters
    int i;
    int j;

    //copy elements into the temporary arrays
    for (i = 0; i < n; i++)
    {
        leftTemp[i] = arr[left + i];
    }

    for (j = 0; j < m; j++)
    {
        rightTemp[j] = arr[middle + 1 + j];
    }

    //reset counters
    i = 0;
    j = 0;

    int k = left;

    //merge the temporary arrays back into the original array.
    while (i < n && j < m)
    {
        if (leftTemp[i] <= rightTemp[j])
        {
            arr[k++] = leftTemp[i++];
        }
        else
        {
            arr[k++] = leftTemp[i++];
        }
    }

    //add remaining elements if there are any
    while (i < n)
    {
        arr[k++] = leftTemp[i++];
    }

    while (j < m)
    {
        arr[k++] = rightTemp[j++];
    }
}

//method to print array elements.
static void print(int[] a)
{
    foreach (int num in a)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

//method to calculate amount of time taken in milliseconds
static void timeCalc(Stopwatch stopwatch)
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
static void runBubble(int[] arr, Stopwatch stopwatch)
{
    stopwatch.Start();
    bubbleSort(arr);
    stopwatch.Stop();
    Console.WriteLine("bubble sort");
    timeCalc(stopwatch);
    stopwatch.Reset();
}

//method to run merge sort and measure time taken.
static void runMerge(int[] arr, Stopwatch stopwatch)
{
    stopwatch.Start();
    mergeSort(arr, 0, arr.Length - 1);
    stopwatch.Stop();
    Console.WriteLine("merge sort");
    timeCalc(stopwatch);
    stopwatch.Reset();
}

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
print(array);

//run bubble sort multiple times
runBubble(arr, stopwatch);
//reset temporary array to original order
Array.Copy(array, arr, array.Length);
runBubble(arr, stopwatch);
Array.Copy(array, arr, array.Length);
runBubble(arr, stopwatch);
Array.Copy(array, arr, array.Length);
runBubble(arr, stopwatch);
Array.Copy(array, arr, array.Length);
runBubble(arr, stopwatch);
Array.Copy(array, arr, array.Length);

//run merge sort multiple times
runMerge(arr, stopwatch);
Array.Copy(array, arr, array.Length);
runMerge(arr, stopwatch);
Array.Copy(array, arr, array.Length);
runMerge(arr, stopwatch);
Array.Copy(array, arr, array.Length);
runMerge(arr, stopwatch);
Array.Copy(array, arr, array.Length);
runMerge(arr, stopwatch);

//algorithms are run multiple times to get an average.