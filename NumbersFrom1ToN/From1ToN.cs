﻿//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
//Examples:

//n	output
//3	1 2 3
//5	1 2 3 4 5


using System;


class From1ToN
{
    static void Main()
    {   
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        for (int number = 1; number<=n; number++)
             {
                 Console.Write(number + " ");
             }
    }
}

