/*  Write a method that checks if the element at given position in given array of integers 
 *  is bigger than its two neighbors (when such exist).
 */


using System;

class ElementIsBiggerThanItsNeighbours
{
    static void Main()
    {
        int[] numbersArray = new int[]{
            5, 3, 8, 8, 2, 22, 1, 8, 6, 2, 1, 0, 4, 7, 9, 2,
        };
        int position = 3;
    }

    public static void check(int position, int[] array)
    {
        if (position == 0)
        {
            if (array[position] > array[position + 1])
            {
                Console.WriteLine("This number has only one neighbour and it is bigger than it...");
            }
            else
            {
                Console.WriteLine("This number has only one neighbour and it is not bigger than it...");
            }
        }

        else if (position == array.Length - 1)
        {
            if (array[position] > array[position - 1])
            {
                Console.WriteLine("This number has only one neighbour and it is bigger than it...");
            }
            else
            {
                Console.WriteLine("This number has only one neighbour and it is not bigger than it...");
            }
        }
        else
        {
            if (array[position] > array[position + 1] && array[position] > array[position - 1])
            {
                Console.WriteLine("This number is bigger than its neighbours...");
            }
            else
            {
                Console.WriteLine("This number is not bigger than its neighbours...");
            }
        }
    }
}