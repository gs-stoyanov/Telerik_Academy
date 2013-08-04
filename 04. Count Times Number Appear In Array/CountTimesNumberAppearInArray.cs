/*  Write a method that counts how many times given number appears in given array.
 *  Write a test program to check if the method is working correctly.
 */


using System;

class CountTimesNumberAppearInArray
{
    static void Main()
    {
        int[] numbersArray = new int[]{
            5, 7, 8, 3, 9, 5, 6, 8, 9, 1, 0,
        };

        int number = 5;
        int count = CountTimes(number, numbersArray);

        Console.WriteLine("Number {0} appears {1} times in the array... ", number, count);
    }

    public static int CountTimes(int number, int[] array)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num == number)
            {
                count++;
            }
        }
        return count;
    }
}