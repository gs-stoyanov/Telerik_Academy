/*  Write a method GetMax() with two parameters that returns the bigger of two integers.
 *  Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
 */


using System;

class GetMaxMethod
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers. ");
        int[] numbers = new int[3]; //Declaring the array to hold the three numbers
        
        //Loop to collect the numbers in array
        for (int i = 0; i < 3; i++)
        {
            Console.Write("{0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        //Calling the method
        int biggestNumber = GetMax(GetMax(numbers[0], numbers[1]), numbers[2]);
        PrintBiggestNumber(biggestNumber);
    }

    //Thid method calculates the biggest number 
    public static int GetMax(int a, int b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    //This method  prints the biggest number
    public static void PrintBiggestNumber(int biggestNumber)
    {
        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}