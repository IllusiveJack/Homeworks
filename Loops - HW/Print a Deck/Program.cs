using System;

namespace Print_a_Deck
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter to which card do you want the counter to go: ");
            string sign = Console.ReadLine().ToUpper();
            int length = 0;

            switch (sign)
            {
                case "J":
                    length = 11;
                    break;
                case "Q":
                    length = 12;
                    break;
                case "K":
                    length = 13;
                    break;
                case "A":
                    length = 14;
                    break;
                default:
                    length = int.Parse(sign);
                    break;
            }

            for (int i = 2; i <= length; i++)
                switch (i)
                {
                    case 11:
                        sign = "J";
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", sign);
                        break;
                    case 12:
                        sign = "Q";
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", sign);
                        break;
                    case 13:
                        sign = "K";
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", sign);
                        break;
                    case 14:
                        sign = "A";
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", sign);
                        break;
                    default:
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        break;
                }

        }
    }
}
