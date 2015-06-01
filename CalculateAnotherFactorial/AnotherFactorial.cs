//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
//Examples:

//n	k	n! / (k! * (n-k)!)
//3	2	3
//4	2	6
//10	6	210
//52	5	2598960

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Enter n (n<100): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k (1<k<n): ");
        int k = int.Parse(Console.ReadLine());
        BigInteger resultpart1 = 1;
        BigInteger resultpart2 = 1;

        if (n < 100 && n > 1 && k > 1 && n > k)
        {
            for (int i = n; i > k; i--)
            {
                resultpart1 *= i;    // 7*6*5*4*3*2*1 / 4*3*2*1 = 7*6*5* that is n!/k!; next to calculate (n-k)!

            }

            for (int j = 2; j <= (n - k); j++) // calculate (n-k)!
            {
                resultpart2 *= j;
            }

            BigInteger finalresult = resultpart1 / resultpart2;
            Console.WriteLine("Result n!/k! * (n-k)! = {0} ", finalresult);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}

