using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please input a value: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine(a * 10);
                    break;
                case 2:
                    Console.WriteLine(a * 10);
                    break;
                case 3:
                    Console.WriteLine(a * 10);
                    break;
                case 4:
                    Console.WriteLine(a * 100);
                    break;
                case 5:
                    Console.WriteLine(a * 100);
                    break;
                case 6:
                    Console.WriteLine(a * 100);
                    break;
                case 7:
                    Console.WriteLine(a * 1000);
                    break;
                case 8:
                    Console.WriteLine(a * 1000);
                    break;
                case 9:
                    Console.WriteLine(a * 1000);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
