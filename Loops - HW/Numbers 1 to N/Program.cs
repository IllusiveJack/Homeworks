using System;

namespace Numbers_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number you want the loop to stop at: ");
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
