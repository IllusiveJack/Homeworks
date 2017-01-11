using System;

namespace Selection_sort
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter the size of the array: ");
            int N = int.Parse(Console.ReadLine());
            int[] theArray = new int[N];
            int i, j;

            for (i = 0; i < N; i++)
            {
                Console.Write("Please enter array #" + (i + 1) + ": ");
                theArray[i] = int.Parse(Console.ReadLine());
            }

            int minElement = int.MaxValue;
            int minIndex = 0;

            for (int p = 0; p < N; p++)
            {
                for (j = p; j < N; j++)
                {
                    if (theArray[j] < minElement)
                    {
                        minElement = theArray[j];
                        minIndex = j;
                    }
                }
                if (minElement != p)
                {
                    int temp = theArray[p]; ;
                    theArray[p] = minElement;
                    theArray[minIndex] = temp;
                    minElement = int.MaxValue;
                }
            }

            for (int k = 0; k < N; k++)
            {
                Console.WriteLine(theArray[k]);
            }
        }
    }
}
