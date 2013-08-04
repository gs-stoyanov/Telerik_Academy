/*  Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
 *  Write a program to test this method.
 */  


using System;

class HelloUser
{
    // This Method asks for username
    static void Main()
    {
        Console.WriteLine("Hi. What's your name?");
        Console.Write("- ");
        string userName = Console.ReadLine();
        PrintUserName(userName);
    }

    // This Method Prints Username
    public static void PrintUserName(string username)
    {
        Console.WriteLine("Hello {0} !", username);
    }
}