//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
////The output is like in the examples below.
////Example 1:

////input	output
////3 
////2 
////5 
//1	min = 1 
//max = 5 
//sum = 8 
//avg = 2.67
//Example 2:

//input	output
//2 
//-1 
//4	min = -1 
//max = 4 
//sum = 3 
//avg = 1.50

using System;

    class MinMaxSumAndAverage
    {
        static void Main()
        {
         Console.WriteLine("Enter number of lines: ");
         int n = int.Parse(Console.ReadLine()); // number of lines
         int lines = 0;
         double sum = 0;
         int i = 0; // the numbers to be entered
         int m = 0; // holder if "i" values;
         int r = 0; // holder if "i" values;

         for (lines = 1; lines <= n; lines++)
         {
             r = i;
             Console.WriteLine("Enter next number: ");
             i = int.Parse(Console.ReadLine()); // as long as # lines <=n, pick new i
             sum += i;
             m = i;
             if (m > r)
             {
                 Console.WriteLine("The maximum value of i is: {0} ", m);
             }
             else
             {
                 Console.WriteLine("The maximum value of i is: {0} ", r);
             }

             if (m < r)
             {
                 Console.WriteLine("The minimum value of i is: {0} ", m);
             }
             else
             {
                 Console.WriteLine("The minimum value of i is: {0} ", r);
             }
         }
            double avg = (sum/n);
            Console.WriteLine("sum = {0}, average = {1:0.00}", sum, avg);
        }
    }

