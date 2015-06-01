//Problem 2. Numbers Not Divisible by 3 and 7

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
//Examples:

//n	output
//3	1 2
//10	1 2 4 5 8 10

using System;

class NotDivisibleBy3And7
{
    static void Main()
    {

        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        for (int number = 1; number <=n; number++)
        {
            if ((number % 3 !=0) && (number %7 !=0))
            {
                Console.Write(number + " ");
            }
        }

    }
}

