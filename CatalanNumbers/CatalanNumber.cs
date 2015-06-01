//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
//Examples:

//n	Catalan(n)
//0	1
//5	42
//10	16796
//15	9694845

//The formula for Catalan numbers: C = (2N)! / ((N + 1)! * N!) .

using System;
using System.Numerics;


class CatalanNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        BigInteger nthnumber = 1;
        if (number >= 0 && number <=100)
        {
            for (int i = number; i >= 1; i--)
            {
                nthnumber *= (number + i)/i; // simplified formula // 3+3/3* 3+2/2*3+1/1 = 2*2.5*4 = 
            }
            Console.WriteLine("The N-th number of Catalan sequence = {0}", nthnumber);
        }
            
        
        else
        {
            Console.WriteLine("Wrong Input!");

        }

    }
}

