/*  Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
 *  Use variable number of arguments.
 */


using System;

class CalculatingSomeValues
{
    static void Main()
    {
        int minNumber = GetMin(15, 9, 7, 6);
        int maxNumber = GetMax(8, 4, 3, 9, 1);
        decimal averageNumber = GetAverage(15, 3, 5, 10, 0, 4);
        int sum = GetSum(5, 8, 9, 3, 1, 2, 5);
        int product = GetProduct(5, 8, 9, 5, 3, 9, 7, 1, 2);

        Console.WriteLine("The Minimum Number is {0}", minNumber);
        Console.WriteLine("The Maximum Number is {0}", maxNumber);
        Console.WriteLine("The Average Number is {0}", averageNumber);
        Console.WriteLine("The Sum is {0}", sum);
        Console.WriteLine("The Product is {0}", product);
    }

    // Searching for the minimum number
    public static int GetMin(params int[] numbers)
    {
        // Define that the current minimu number is the first number from the array, so the loop will start from the next one
        int currMinNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (currMinNumber > numbers[i])
            {
                currMinNumber = numbers[i];
            }
        }
        return currMinNumber;
    }

    // Searching for the maximum number
    public static int GetMax(params int[] numbers)
    {
        // Define that the current maximum number is the first number from the array, so the loop will start from the next one
        int currMaxNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (currMaxNumber < numbers[i])
            {
                currMaxNumber = numbers[i];
            }
        }
        return currMaxNumber;
    }
    
    // Searching for the average number
    public static decimal GetAverage(params int[] numbers)
    {
        // Sum will hold the sum of the numbers in the array
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }

    // Calculating the sum
    public static int GetSum(params int[] numbers)
    {
        // Calculating the sum by adding each number to the sum variable
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    // Calculating the product
    public static int GetProduct(params int[] numbers)
    {
        // Calculating the sum by adding each number to the sum variable
        int product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}