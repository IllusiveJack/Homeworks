using System;

namespace MMSA__Min__Max__Sum__Average__of_N_Numbers
{
    class Program
    {
        static void Main()
        {
            int MinN = 10000, MaxN = -10000, sum = 0;
            Console.Write("How many numbers are you going to enter: ");
            int numN = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numN; i++)
            {
                int currN = int.Parse(Console.ReadLine());

                if(currN < MinN)
                {
                    MinN = currN;
                }
                if(currN > MaxN)
                {
                    MaxN = currN;
                }

                sum += currN;
            }

            double avg = Convert.ToDouble(sum) / Convert.ToDouble(numN);

            Console.WriteLine("min = {0:f2}",MinN);
            Console.WriteLine("max = {0:f2}",MaxN);
            Console.WriteLine("sum = {0:f2}",sum);
            Console.WriteLine("average = {0:f2}",avg);
        }
    }
}
