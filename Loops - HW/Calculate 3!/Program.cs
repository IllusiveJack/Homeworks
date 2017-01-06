using System;
using System.Numerics;

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
            BigInteger result = 1;
            BigInteger bottom = 1;
            BigInteger bottom2 = 1;
            BigInteger top= 1;
            int NmK = N-K;

            for (int i = N, j = K, k = NmK; i >= 1; i--, j--, k--)
            {
                if (j == 0)
                {
                    j = 1;
                }
                if(k == 0)
                {
                    k = 1;
                }
                top *= i;
                bottom *= j;
                bottom2 *= k;

            }
            result = (top / (bottom*bottom2));

            Console.WriteLine("{0}", result);
        }
    }
}
