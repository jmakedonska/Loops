//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
//Examples:

//n	k	n! / k!
//5	2	60
//6	5	6
//8	3	6720


using System;
using System.Numerics;

class NKFactorialDivision
{
    static void Main()
    {
            Console.Write("Enter k (1<k<n): ");
            int K = int.Parse(Console.ReadLine());
            Console.Write("Enter n (n<100): ");
            int N = int.Parse(Console.ReadLine());
            int result = 1;

            if (N < 100 && N > 1 && K > 1 && N > K)
            {
                for (int i = N; i > K; i --)
                {
                    result *= i;    // 7*6*5*4*3*2*1 / 4*3*2*1 = 7*6*5*
                }
                Console.WriteLine("The result from division of N! by K! is:{0}", result);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
    
    }
}
