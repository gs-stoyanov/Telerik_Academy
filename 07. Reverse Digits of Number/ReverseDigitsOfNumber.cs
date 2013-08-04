/*  Write a method that reverses the digits of given decimal number. Example: 256  652
 */

using System;

class ReverseDigitsOfNumber
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine()); //getting the number

        //Calling the method that reverses the method
        ReverseDigits(number);
    }

    public static void ReverseDigits(int number)
    {
        string numberToString = number.ToString(); //converting the number to string in order to use its digits
        string reversedNumber = ""; //this will store the reversed number
        for (int i = numberToString.Length - 1; i >= 0; i--)
        {
            reversedNumber += numberToString[i];
        }

        //printing the result
        Console.WriteLine("Your reversed number is {0}", reversedNumber);
    }
}