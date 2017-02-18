using System;

namespace Factorial
{
    class Program
    {
        static void Factorial(int num)
        {
            int result = 1;
            for (int i = num; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }

        static void Array(int num, int r)
        {
            int[,] result = new int[r, num + 1];
            int counter = 1;
            int scounter = 1;

            for (int i = 0; i < num/r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    result[i, j] = counter;
                    if (counter == num)
                    {
                        break;
                    }
                    counter++;
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < num/r; j++)
                {

                    Console.Write(result[i,j]);
                    if (scounter == num)
                    {
                        break;
                    }
                    scounter++;
                }
                Console.WriteLine();
            }
        }

        static void Square(int num, int pow)
        {
            int result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            Console.WriteLine(result);
        }


        static void Main()
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int choice;

            do
            {
                Console.Write(@"Choose what do you want to do with the number: 
1. Get the factorial(N!)
2. Get the sequence of numbers from 1 to the number entered(1,2,3...N)
3. Get the power of the number(N^P)
Number: ");
                choice = int.Parse(Console.ReadLine());

            }
            while (choice > 3 || choice < 1);

            if (choice == 1)
            {
                Factorial(number);
            }
            else if(choice == 2)
            {
                Console.Write("Enter the length per row for a possible array: ");
                int rows = int.Parse(Console.ReadLine());
                Array(number, rows);
            }
            else if(choice == 3)
            {
                Console.Write("Please enter the power to get the number on it: ");
                int power = int.Parse(Console.ReadLine());
                Square(number, power);
            }

        }
    }
}
