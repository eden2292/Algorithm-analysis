using System.Diagnostics;
using System.Timers;

static void bubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            if (arr[j] > arr[j+1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

static void mergeSort(int[] arr, int left, int right)
{
    if (left<right)
    {
        int middle = left + (right - left) / 2;

        mergeSort(arr, left, middle);
        mergeSort(arr, middle + 1, right);

        merge(arr, left, middle, right);
    }
}

static void merge(int[] arr, int left, int middle, int right)
{
    int n = middle - left + 1;
    int m = right - middle;

    int[] leftTemp = new int[n];
    int[] rightTemp = new int[m];

    int i;
    int j;

    for(i = 0; i<n; i++)
    {
        leftTemp[i] = arr[left + i];
    }

    for(j = 0; j<m; j++)
    {
        rightTemp[j] = arr[middle + 1 + j];
    }

    i = 0;
    j = 0;

    int k = left;

    while(i < n && j < m)
    {
        if( leftTemp[i] <= rightTemp[j])
        {
            arr[k++] = leftTemp[i++];
        }
        else
        {
            arr[k++] = leftTemp[i++]; 
        }
    }

    while(i < n)
    {
        arr[k++] = leftTemp[i++];
    }

    while (j < m)
    {
        arr[k++] = rightTemp[j++];
    }
}

static void print(int[] a)
{
    foreach(int num in a)
    {
        Console.WriteLine(num + " " );
    }
}

static void timeCalc(Stopwatch stopwatch)
{
    long ticks = stopwatch.ElapsedTicks;
    long frequency = Stopwatch.Frequency;

    double timeTaken = ((double)ticks / frequency) * 1000;

    Console.WriteLine("Time taken = " + timeTaken);

}

Random rand = new Random();

int[] array = new int[10];

for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 100000);
}
int[] arr = new int[array.Length];
Array.Copy(array, arr, array.Length);

Console.WriteLine("unsorted array:");
print(array);

stopwatch.Start();
bubbleSort(arr);
stopwatch.Stop();
Console.WriteLine("bubble sort 1");
//print(arr);
timeCalc(stopwatch);
stopwatch.Reset();

//print(array);

Array.Copy(array, arr, array.Length);

stopwatch.Start();
bubbleSort(arr);
stopwatch.Stop();
Console.WriteLine("bubble sort 2");
//print(arr);
timeCalc(stopwatch);
stopwatch.Reset();

Array.Copy(array, arr, array.Length);

stopwatch.Start();
bubbleSort(arr);
stopwatch.Stop();
Console.WriteLine("bubble sort 3");
//print(arr);
timeCalc(stopwatch);
stopwatch.Reset();

Array.Copy(array, arr, array.Length);

stopwatch.Start();
bubbleSort(arr);
stopwatch.Stop();
Console.WriteLine("bubble sort 4");
//print(arr);
timeCalc(stopwatch);
stopwatch.Reset();

Array.Copy(array, arr, array.Length);

stopwatch.Start();
bubbleSort(arr);
stopwatch.Stop();
Console.WriteLine("bubble sort 5");
//print(arr);
timeCalc(stopwatch);
stopwatch.Reset();

Array.Copy(array, arr, array.Length);

stopwatch.Start();
mergeSort(arr, 0, arr.Length - 1);
stopwatch.Stop();
Console.WriteLine("merge sort 1");
//print(arr);
timeCalc(stopwatch);
stopwatch.Reset();

//print(array);

Array.Copy(array, arr, array.Length);

stopwatch.Start();
mergeSort(arr, 0, arr.Length - 1);
stopwatch.Stop();
Console.WriteLine("merge sort 2");
//print(arr);
timeCalc(stopwatch);
stopwatch.Reset();

Array.Copy(array, arr, array.Length);

stopwatch.Start();
mergeSort(arr, 0, arr.Length - 1);
stopwatch.Stop();
Console.WriteLine("merge sort 3");
//print(arr);
timeCalc(stopwatch);
stopwatch.Reset();

Array.Copy(array, arr, array.Length);

stopwatch.Start();
mergeSort(arr, 0, arr.Length - 1);
stopwatch.Stop();
Console.WriteLine("merge sort 4");
//print(arr);
timeCalc(stopwatch);
stopwatch.Reset();

Array.Copy(array, arr, array.Length);

stopwatch.Start();
mergeSort(arr, 0, arr.Length - 1);
stopwatch.Stop();
Console.WriteLine("merge sort 5");
//print(arr);
timeCalc(stopwatch);
stopwatch.Reset();
