﻿//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
//Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1 2 3 4
//        2 3                 2 3 4               2 3 4 5
//                            3 4 5               3 4 5 6
//                                                4 5 6 7


using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 1 || number > 20)
        {
            Console.WriteLine("Invalid Number");
        }
        else
        {
            Console.WriteLine("The matrix of numbers is:");
            Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j < number + i; j++) // starts from i+1
                {
                    Console.Write("{0, 3}", j); //prints each line with space 3
                }
                Console.WriteLine(); // separates each j sequence by a line
            }
        }
    }

}

