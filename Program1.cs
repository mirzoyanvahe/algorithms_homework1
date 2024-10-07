using System;

class RecursiveInsertionSort
{
    // Recursive function to sort an array using insertion sort
    public static void InsertionSort(int[] arr, int n)
    {
        // Base case: If the array has only one element, it's already sorted
        if (n <= 1)
        {
            return;
        }

        // Sort first n-1 elements recursively
        InsertionSort(arr, n - 1);

        // Insert the nth element in its correct position
        int last = arr[n - 1];
        int j = n - 2;

        // Move elements of arr[0..n-1] that are greater than last, to one position ahead of their current position
        while (j >= 0 && arr[j] > last)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = last;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        Console.WriteLine("Original array: ");
        Console.WriteLine(string.Join(" ", arr));

        InsertionSort(arr, arr.Length);

        Console.WriteLine("Sorted array: ");
        Console.WriteLine(string.Join(" ", arr));
    }
}