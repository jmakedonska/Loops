//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
//Examples:

//numbers	result
//2 1 1 6 3	yes
//product = 6	
//3 10 4 6 5 1	yes
//product = 60	
//4 3 2 5 2	no
//odd_product = 16	
//even_product = 15	


using System;

class OddAndEven
{
    static void Main()
    {
        Console.WriteLine("Enter integers: ");
        string input = Console.ReadLine();
        string[] array = input.Split(' ');

        int productodd = 1;
        int producteven = 1;

        for (int i = 0; i <= array.Length; i++)
        {
            int number = int.Parse(array[i]);
            if (number % 2 == 0)
            {
                producteven *= number;
            }
            
            else
            {
                productodd *= number;     
            }
        }
        Console.WriteLine("The product of even numbers is {0}", producteven);
        Console.WriteLine("The product of odd numbers is {0}", productodd);

        if (producteven == productodd)
        {
            Console.WriteLine("Is the product of the odd elements equal to the product of the even elements? : yes");
        }
        else
        {
            Console.WriteLine("Is the product of the odd elements equal to the product of the even elements? : no");
        }
    }
}
