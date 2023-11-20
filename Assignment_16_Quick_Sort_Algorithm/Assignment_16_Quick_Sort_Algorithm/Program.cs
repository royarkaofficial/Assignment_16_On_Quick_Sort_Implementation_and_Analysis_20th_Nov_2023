using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16_Quick_Sort_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 4, 5, 6, 7, 3, 1, 15 };

            Console.WriteLine("Unsorted Array:");
            PrintArray(array);

            QuickSortAlgorithm(array, 0, array.Length - 1);

            Console.WriteLine("Sorted Array:");
            PrintArray(array);
            int[] array20 = GenerateRandomArray(20);
            Console.WriteLine("Unsorted Array (20 elements):");
            PrintArray(array20);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QuickSortAlgorithm(array20, 0, array20.Length - 1);
            stopwatch.Stop();

            Console.WriteLine($"Sorted Array (20 elements):");
            PrintArray(array20);
            Console.WriteLine($"Is Array Sorted: {IsSorted(array20)}");
            Console.WriteLine($"Time to sort 20 elements: {stopwatch.ElapsedMilliseconds} ms\n");

            int[] array30 = GenerateRandomArray(30);
            Console.WriteLine("Unsorted Array (30 elements):");
            PrintArray(array30);

            stopwatch.Restart();
            QuickSortAlgorithm(array30, 0, array30.Length - 1);
            stopwatch.Stop();

            Console.WriteLine($"Sorted Array (30 elements):");
            PrintArray(array30);
            Console.WriteLine($"Is Array Sorted: {IsSorted(array30)}");
            Console.WriteLine($"Time to sort 30 elements: {stopwatch.ElapsedMilliseconds} ms\n");

            int[] array50 = GenerateRandomArray(50);
            Console.WriteLine("Unsorted Array (50 elements):");
            PrintArray(array50);

            stopwatch.Restart();
            QuickSortAlgorithm(array50, 0, array50.Length - 1);
            stopwatch.Stop();

            Console.WriteLine($"Sorted Array (50 elements):");
            PrintArray(array50);
            Console.WriteLine($"Is Array Sorted: {IsSorted(array50)}");
            Console.WriteLine($"Time to sort 50 elements: {stopwatch.ElapsedMilliseconds} ms\n");
        }
        static void QuickSortAlgorithm(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSortAlgorithm(arr, low, pivotIndex - 1);
                QuickSortAlgorithm(arr, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100); // Adjust range as needed
            }
            return array;
        }
    }
}