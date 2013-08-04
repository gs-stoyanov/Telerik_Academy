/*  Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
 *  the last digit is kept in arr[0]). 
 *  Each of the numbers that will be added could have up to 10 000 digits.
 */  


using System;
using System.Numerics;

class IntegerAsArrayOfDigit
{
    static void Main()
    {
        byte[] arrayOne = new byte[] { 5, 1, 5, 3, 4, 7, 9, 5, 8, 6, 5, 5 };
        Array.Reverse(arrayOne);
        byte[] arrayTwo = new byte[] { 2, 8, 9, 4, 6, 9, 2, 0, 1, 7, 6, 3, 0, 1, 5 };
        Array.Reverse(arrayTwo);

        BigInteger arrayOneDigits = BigInteger.Parse(BuildString(arrayOne));
        BigInteger arrayTwoDigits = BigInteger.Parse(BuildString(arrayTwo));
        SumArrays(arrayOneDigits, arrayTwoDigits);
    }

    public static string BuildString(byte[] arrayOne)
    {
        string result = "";
        foreach (byte num in arrayOne)
        {
            result += num;
        }
        return result;
    }

    public static void SumArrays(BigInteger arrayOne, BigInteger arrayTwo)
    {
        Console.WriteLine(arrayOne + arrayTwo);
    }
}