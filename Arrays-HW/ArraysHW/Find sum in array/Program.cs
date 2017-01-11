using System;

namespace Find_sum_in_array
{
    class Program
    {
        static void Main()
        {
            Console.Write("The size of the integer: ");
            int N = int.Parse(Console.ReadLine());
            int[] UserArray = new int[N];
            int sum = 0;
            bool solution = false;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Please enter array #" + (i + 1) + ": ");
                UserArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Please enter the sum of the arrays you are looking for: ");
            int S = int.Parse(Console.ReadLine());

            for(int j = 0; j < N; j++)
            {
                for(int k = j; k < N; k++)
                {
                    sum += UserArray[k];
                    if(sum == S)
                    {
                        solution = true;
                        Console.WriteLine("The following sequence has the sum of {0}: ", S);
                        for(int print = j; print <= k; print++)
                        {
                            Console.Write("{0} ", UserArray[print]);
                        }
                        Console.WriteLine();
                    }
                }
                sum = 0;
            }
            if(!solution)
            {
                Console.WriteLine("There is no sequence with that sum");
            }
        }
    }
}
