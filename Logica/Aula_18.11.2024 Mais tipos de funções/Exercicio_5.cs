using System;
using System.Diagnostics;

namespace Exercicio_5
{
    class Program
    {
        static int MeasureTime(Action sortMethod)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            sortMethod();
            stopwatch.Stop();
            return (int)stopwatch.ElapsedMilliseconds;
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        // Merge Sort
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];
            for (int i = 0; i < n2; i++)
                rightArray[i] = arr[mid + 1 + i];

            int iLeft = 0, iRight = 0, k = left;
            while (iLeft < n1 && iRight < n2)
            {
                if (leftArray[iLeft] <= rightArray[iRight])
                {
                    arr[k] = leftArray[iLeft];
                    iLeft++;
                }
                else
                {
                    arr[k] = rightArray[iRight];
                    iRight++;
                }
                k++;
            }

            while (iLeft < n1)
            {
                arr[k] = leftArray[iLeft];
                iLeft++;
                k++;
            }

            while (iRight < n2)
            {
                arr[k] = rightArray[iRight];
                iRight++;
                k++;
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[100000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 1000001);
            }

            var bubbleSortTime = MeasureTime(() => BubbleSort((int[])arr.Clone()));
            var selectionSortTime = MeasureTime(() => SelectionSort((int[])arr.Clone()));
            var insertionSortTime = MeasureTime(() => InsertionSort((int[])arr.Clone()));
            var mergeSortTime = MeasureTime(() => MergeSort((int[])arr.Clone(), 0, arr.Length - 1));

            Console.WriteLine($"Bubble Sort: {bubbleSortTime}ms");
            Console.WriteLine($"Selection Sort: {selectionSortTime}ms");
            Console.WriteLine($"Insertion Sort: {insertionSortTime}ms");
            Console.WriteLine($"Merge Sort: {mergeSortTime}ms");

            int minTime = Math.Min(bubbleSortTime, Math.Min(selectionSortTime, Math.Min(insertionSortTime, mergeSortTime)));
            if (minTime == bubbleSortTime) Console.WriteLine("Melhor desempenho: Bubble Sort");
            else if (minTime == selectionSortTime) Console.WriteLine("Melhor desempenho: Selection Sort");
            else if (minTime == insertionSortTime) Console.WriteLine("Melhor desempenho: Insertion Sort");
            else Console.WriteLine("Melhor desempenho: Merge Sort");
        }
    }
}
