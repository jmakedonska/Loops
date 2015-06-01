//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
//output

//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//…  
//K of spades, K of clubs, K of hearts, K of diamonds
//A of spades, A of clubs, A of hearts, A of diamonds
//Note: You may use the suit symbols instead of text.


using System;

class DeckOf52Cards
{
    static void Main()
    {
        int i = int.Parse (Console.ReadLine());
        string a = "of spades";
        string b = "of clubs";
        string c = "of hearts";
        string d = "of diamonds";

            for (i = 2; i < 15; i++)
            {
                if (i > 1 && i < 11)
                {
                    Console.WriteLine(i + " " + (a) + " " + i + " " + (b) + " " + i + " " + (c) + " " + i + " " + (d));

                }
                else
                {
                    for (int j = i; j < i + 1; j++)
                        switch (i)
                        {
                            case 11: Console.WriteLine("D " + " " + (a) + " " + "D " + " " + (b) + " " + "D " + " " + "D " + (c) + " " + "D " + " " + (d)); break;

                            case 12: Console.WriteLine("A " + " " + (a) + " " + "A " + " " + (b) + " " + "A " + " " + "A " + (c) + " " + "A " + " " + (d)); break;

                            case 13: Console.WriteLine("J " + " " + (a) + " " + "J " + " " + (b) + " " + "J " + " " + "J " + (c) + " " + "J " + " " + (d)); break;

                            case 14: Console.WriteLine("K " + " " + (a) + " " + "K " + " " + (b) + " " + "K " + " " + "K " + (c) + " " + "K " + " " + (d)); break;
                            
                        }
                }
            }


        // Same problem with suit symbols:

            //int a = 3;
            //int b = 4;
            //int c = 5;
            //int d = 6;
            // Console.WriteLine((char) a);
            //for (int i = 2; i < 15; i++)
            //{
            //    if (i > 1 && i < 11)
            //    {
            //        Console.WriteLine(" " + ((char)a) + i + " " + ((char)b) + i + " " + ((char)c) + i + " " + ((char)d) + i);

            //    }
            //    else
            //    {
            //        for (int j = i; j < i + 1; j++)
            //            switch (i)
            //            {
            //                case 11: Console.WriteLine((char)a + "D " + (char)b + "D " + ((char)c) + "D " + ((char)d) + "D "); break;
            //                case 12: Console.WriteLine((char)a + "A " + (char)b + "A " + (char)c + "A " + ((char)d) + "A "); break;
            //                case 13: Console.WriteLine((char)a + "J " + (char)b + "J " + (char)c + "J " + ((char)d) + "J "); break;
            //                case 14: Console.WriteLine((char)a + "K " + (char)b + "K " + (char)c + "K " + ((char)d) + "K "); break;
            //            }
            //    }
            //}

    }
}

