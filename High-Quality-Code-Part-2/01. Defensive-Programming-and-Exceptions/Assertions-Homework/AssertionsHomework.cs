﻿using System;
using System.Diagnostics;
using System.Linq;

public class AssertionsHomework
{
    public static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[3]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }

    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr.Count() > 0, "Array is empty!");

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        // is the array actually sorted
        for (int i = 1; i < arr.Length; i++)
        {
            Debug.Assert(arr[i - 1].CompareTo(arr[i]) <= 0, "Array is not sorted!");
        }
    }
  
    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr.Count() > 0, "Array is empty!");
        Debug.Assert(value != null, "Value can not be null!");

        for (int i = 1; i < arr.Length; i++)
        {
            Debug.Assert(arr[i - 1].CompareTo(arr[i]) <= 0, "Use binary search only with sorted arrays!");
        }

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr.Count() > 0, "Array is empty!");
        Debug.Assert(startIndex >= 0, "StartIndex is not in range!");
        Debug.Assert(startIndex < endIndex, "StartIndex is bigger than EndIndex!");
        Debug.Assert(endIndex < arr.Count(), "EndIndex is not in range");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        // is this the minimum element
        for (int i = startIndex; i < endIndex; i++)
        {
            Debug.Assert(arr[minElementIndex].CompareTo(arr[i]) <= 0, "This is not the minimum element index");
        }

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
    where T : IComparable<T>
    {
        Debug.Assert(arr.Count() > 0, "Array is empty!");
        Debug.Assert(value != null, "Value can not be null!");
        Debug.Assert(startIndex >= 0, "StartIndex is not in range!");
        Debug.Assert(startIndex < endIndex, "StartIndex is bigger than EndIndex!");
        Debug.Assert(endIndex < arr.Count(), "EndIndex is not in range");

        for (int i = 1; i < arr.Length; i++)
        {
            Debug.Assert(arr[i - 1].CompareTo(arr[i]) <= 0, "Use binary search only with sorted arrays!");
        }

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;

            Debug.Assert(midIndex >= 0, "Index can not be negative!");

            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        Debug.Assert(Array.IndexOf(arr, value) < 0, "The array has the searchead value but returns - 1.");

        // Searched value not found
        return -1;
    }
}