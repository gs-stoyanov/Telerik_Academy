/*  Write a method that return the maximal element in a portion of array of integers starting at given index. 
 *  Using it write another method that sorts an array in ascending / descending order.
 */


using System;

class MaximalElementInArray
{
    static void Main()
    {
        int[] array = { 6, 44, 90, -123, -69, 900, 55, 12, 700, 0, -130, -9, 32, 250 };
        Console.Write("Please enter index: ");
        int n = int.Parse(Console.ReadLine());
        NewArrayAdd(array, n);
    }

    // sorting descendingly
    public static void DescendingSort(int[] arr)
    {
        Console.WriteLine("Descending sort: ");
        Array.Reverse(arr); // reversing in order to get the array sorted descendingly
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // sorting ascendingly
    public static void AscendingSort(int[] arr)
    {
        Array.Sort(arr); // sorting the array
        Console.WriteLine("The greatest number in the subarray is {0}", arr[arr.Length - 1]); // printing the greatest number
        Console.WriteLine("Ascending sort: ");
        foreach (int num in arr)
        {
            Console.Write(num + " "); // printing the numbers in the array
        }
        Console.WriteLine();
        DescendingSort(arr);
    }
    public static void NewArrayAdd(int[] array, int number)
    {
        // adding new element to the new array
        int[] newArr = new int[array.Length - number];
        for (int i = 0; i < newArr.Length; i++)
        {
            newArr[i] = array[i + number];
        }
        AscendingSort(newArr);
    }
}