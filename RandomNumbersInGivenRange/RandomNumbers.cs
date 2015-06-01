//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
//Examples:

//n	min	max	random numbers
//5	0	1	1 0 0 1 1
//10	10	15	12 14 12 15 10 12 14 13 13 11
//Note: The above output is just an example. Due to randomness, your program most probably will produce different results.


using System;


    class RandomNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number min: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number max: ");
            int max = int.Parse(Console.ReadLine());
            bool inRange = min <= max;
 
            if (inRange)
            {
                Random randomGenerator = new Random(); // generates random numbers
                for (int i = 1; i <= n; i++)
                {   
                    int randomNumber = randomGenerator.Next(min, max);
                    Console.Write(randomNumber + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Correct input --> min <= max");
            }
            
        }
    }

