using System;

namespace Calculate_
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter the number of integers: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of integers on the second line: ");
            int x = int.Parse(Console.ReadLine());
            decimal sum = 1;
            decimal xpower = 1;
            decimal top = 1;

            for (int i = 1, j = 1; i <= N; i++, j++)
            {
                top *= i;
                xpower *= x;
                sum += (top / xpower);

            }

            Console.WriteLine("{0:f5}",sum);
        }
    }
}
