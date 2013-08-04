/*  Write a method that returns the last digit of given integer as an English word. 
 *  Examples: 512  "two", 1024  "four", 12309  "nine".
 */  


using System;

class ReturnLastDigitAsWord
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        ConvertLastDigitToWord(number);
    }

    public static void ConvertLastDigitToWord(int number)
    {
        int lastDigit = number % 10; //Getting the last digit
        string word = ""; //This will hold the english word for the last digit
        
        // This will convert the digit to its english word
        switch (lastDigit)
        {
            case 0:
                word = "zero";
                break;
            case 1:
                word = "one";
                break;
            case 2:
                word = "two";
                break;
            case 3:
                word = "three";
                break;
            case 4:
                word = "four";
                break;
            case 5:
                word = "five";
                break;
            case 6:
                word = "six";
                break;
            case 7:
                word = "seven";
                break;
            case 8:
                word = "eight";
                break;
            case 9:
                word = "nine";
                break;
        }

        // Printing the last number
        Console.WriteLine("The last digit of your number is: {0}", word);
    }
}