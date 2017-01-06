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
            int K = int.Parse(Console.ReadLine());
            int result = 1;
            int xpower = 1;
            int top = 1;

            for (int i = N, j = K; i >= 1; i--, j--)
            {
                if( j == 0)
                {
                    j = 1;
                }
                top *= i;
                xpower *= j;
                
            }
            result = (top / xpower);

            Console.WriteLine("{0}", result);
        }
    }
}