/*  Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
 *  Use the method from the previous exercise.
 */


using System;

class IndexOfElementInArray
{
    static void Main()
    {
        int[] numbersArray = new int[]{
            5, 3, 8, 8, 2, 22, 1, 8, 6, 2, 1, 0, 4, 7, 9, 2,
        };
        check(numbersArray);
    }

    public static void check(int[] array)
    {
        //At first the index will be -1.. If there is nor such number it will remain -1
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            //If it is the first element in the array, continue
            if (i == 0)
            {
                continue;
            }
            // If it is the last element of the array, break
            else if (i == array.Length - 1)
            {
                break;
            }
            // Else check for current number's neighbours
            else
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    index = i;
                    break;
                }
            }
        }

        if (index == -1)
        {
            Console.WriteLine("There isn't a number in the array that is bigger than its neighbours, so the program returns {0}", index);
        }
        else
        {
            Console.WriteLine("There is a number that is bigger than its neighbours and its index is {0}", index);
        }
    }
}