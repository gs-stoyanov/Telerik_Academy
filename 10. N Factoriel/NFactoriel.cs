/*  Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies 
 *  a number represented as array of digits by given integer number. 
 */


using System;
using System.Numerics;

class NFactoriel
{
    static void Main()
    {
        // reading from console
        Console.Write("Please enter n: "); 
        int n = int.Parse(Console.ReadLine());

        // calling the method to solve the task
        CalculateFactoriel(n);
    }

    private static void CalculateFactoriel(int n)
    {
        BigInteger factoriel = 1; // this will store the factoriel
        for (int i = 1; i <= n; i++)
        {
            factoriel *= i; // multiplying the factoriel and the next number 
        }
        // Printing the result
        Console.WriteLine("{0}! = {1}", n, factoriel);
    }
}