/*  Write a program that can solve these tasks:
 *      Reverses the digits of a number
 *      Calculates the average of a sequence of integers
 *      Solves a linear equation a * x + b = 0
 *  Create appropriate methods.
 *  Provide a simple text-based menu for the user to choose which task to solve.
 *  Validate the input data:
 *      The decimal number should be non-negative
 *      The sequence should not be empty
 *      a should not be equal to 0
 */  


using System;

class SolvingDifferentTasks
{
    static void PrintMenu()
    {
        Console.WriteLine("Type the number of the task you want to solve from the menu below...");
        Console.WriteLine("1. Reverse The Digits of a Number");
        Console.WriteLine("2. Calculates The Average of a Sequence of Integers");
        Console.WriteLine("3. Solve a Linear Equation like: a*x + b = 0");
        Console.Write("Which Task Do You Choose: ");
    }

    static void ReadFromConsole()
    {
        int taskNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(new String('-', 50));
        switch (taskNumber)
        {
            case 1:
                ReverseDigits();
                break;

            case 2:
                CalculateAverage();
                break;

            case 3:
                SolveLinearEquation();
                break;

            default:
                Console.WriteLine("Incorrect Task Number...");
                break;
        }
    }

    public static void ReverseDigits()
    {
        Console.Write("Your Number is:  ");
        Decimal number = Decimal.Parse(Console.ReadLine());

        while (number < 0)
        {
            Console.WriteLine("That Number is Negative. Please enter non-negative number...");
            number = Decimal.Parse(Console.ReadLine());
        }
        string numberToString = Convert.ToString(number);
        string reversedNumber = "";

        for (int i = numberToString.Length - 1; i >= 0; i--)
        {
            reversedNumber += numberToString[i];
        }

        Console.WriteLine("The Reversed Number is {0} ", reversedNumber);
    }

    public static void CalculateAverage()
    {
        Console.Write("How Many Numbers Will You Enter: ");
        int countNumbers = int.Parse(Console.ReadLine());
        while (countNumbers <= 0)
        {
            Console.Write("You can't enter less than one number...");
            countNumbers = int.Parse(Console.ReadLine());
        }
        int[] array = new int[countNumbers];
        for (int i = 0; i < countNumbers; i++)
        {
            Console.Write("Your next number is: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int arraySum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            arraySum += array[i];
        }
        decimal averageNumber = (decimal)arraySum / array.Length;
        Console.WriteLine("The Average Number in the Sequence is {0}", averageNumber);
    }

    public static void SolveLinearEquation()
    {
        Console.Write("a = ");
        decimal a = decimal.Parse(Console.ReadLine());
        while (a < 0)
        {
            Console.WriteLine("a must be greater than zero");
            Console.Write("a = ");
            a = decimal.Parse(Console.ReadLine());
        }
        Console.Write("b = ");
        decimal b = decimal.Parse(Console.ReadLine());
        decimal x = -b / a;
        Console.WriteLine("X is {0}", x);
    }

    static void Main()
    {
        PrintMenu();
        ReadFromConsole();
    }
}