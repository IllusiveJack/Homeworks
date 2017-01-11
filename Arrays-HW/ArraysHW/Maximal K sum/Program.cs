using System;
using System.Linq;

namespace Maximal_K_sum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number of elements in the array: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the maximum numbers you want summed: ");
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int sum = 0;

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("Please enter array number " + i + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] sortedCopy = (from element in array orderby element ascending select element).ToArray();

            for(int k = N - 1; k >= N-K; k--)
            {
                sum += sortedCopy[k];
            }

            Console.WriteLine(sum);
        }
    }
}
