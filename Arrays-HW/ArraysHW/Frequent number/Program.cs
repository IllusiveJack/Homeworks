using System;

namespace Frequent_number
{
    class Program
    {
        static void Main()
        {
            Console.Write("The size of the integer: ");
            int N = int.Parse(Console.ReadLine());
            int[] UserArray = new int[N];
            int RepNumber = 0;
            int Holder = 0;
            int NumHolder = 0;

            for(int i = 0; i < N; i++)
            {
                Console.Write("Please enter array #" + (i+1) + ": ");
                UserArray[i] = int.Parse(Console.ReadLine());
            }

            for(int j = 0; j < N; j++)
            {

                for(int k = j; k < N; k++)
                {
                    if(UserArray[k] == UserArray[j])
                    {
                        RepNumber += 1; 
                        if (RepNumber > Holder)
                        {
                            NumHolder = UserArray[j];
                            Holder = RepNumber;
                        }
                    }
                }
                RepNumber = 0;
            }

            Console.WriteLine(NumHolder + "(" + Holder + " times)");
        }
    }
}
