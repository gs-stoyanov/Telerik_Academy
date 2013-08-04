/*  Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
 *  x2 + 5 = 1x2 + 0x + 5   ->  5 0 1
 */

using System;

class Polynomials
{
    static void Main()
    {
        decimal[] firstPolynomial = { 5, 5, 7 }; // declaring the first polynomial
        decimal[] secondPolynomial = { 0, -5, -1, 6, 7 }; // declaring the second polynomial
        decimal[] result = AddPolynomials(firstPolynomial, secondPolynomial); // saving the result
        PrintResult(result); //calling the method that adds the two polynomials
    }

    // this is the method that adds the two polynomials
    public static decimal[] AddPolynomials(decimal[] first, decimal[] second)
    {
        int resultLength = Math.Max(first.Length, second.Length); // getting the greater polynomial array length in order to use it for the result
        decimal[] result = new decimal[resultLength]; // declaring the new polynomial

        // starting to add the elements of the two polynomials
        for (int i = 0; i < resultLength; i++)
        {
            // if we reached the end of the first polynomial, we only add the elements from the second to the result
            if (i >= first.Length)
            {
                result[i] = second[i];
            }
            // if we reached the end of the second polynomial, we only add the elements from the first polynomial
            else if (i >= second.Length)
            {
                result[i] = first[i];
            }
            // else we add both
            else
            {
                result[i] = first[i] + second[i];
            }
        }
        return result;
    }

    public static void PrintResult(decimal[] result)
    {
        // printing the result, so that the elements with coeficient of zero will not be printed
        for (int i = result.Length - 1; i >= 0; i--)
        {
            // if the coeficient is zero, just continue to the next one
            if (result[i] == 0)
            {
                continue;
            }
            else
            {
                // if the element has x^n, where n>1, then we print the rate too
                if (i > 1)
                {
                    Console.Write("{0} + ", result[i].ToString() + "x^" + i.ToString());
                }
                // if the element has x^1, then we print only x
                else if (i == 1)
                {
                    Console.Write("{0} + ", result[i].ToString() + "x");
                }
                // if the element doesn't have x, then we just print the coeficient  
                else if (i == 0)
                {
                    Console.Write(result[i]);
                }
            }
        }
        // new line 
        Console.WriteLine();
    }
}