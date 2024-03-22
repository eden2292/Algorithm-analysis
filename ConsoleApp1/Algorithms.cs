namespace ConsoleApp1
{
    internal class Algorithms
    {
        //Method for bubble sort
        public static void bubbleSort(int[] arr)
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
        public static void mergeSort(int[] arr, int left, int right)
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

        // method for merge
        public static void merge(int[] arr, int left, int middle, int right)
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
    }
}