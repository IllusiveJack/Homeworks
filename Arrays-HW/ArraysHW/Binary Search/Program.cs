using System;

namespace Binary_Search
{
    class Program
    {
        class BinarySearch
        {
            static void Search(int[] arr, int start, int end, int element)
            {
                if (end <= start)
                {
                    Console.WriteLine("Not Found!");
                    return;
                }
                else
                {
                    int middle = start + (end - start) / 2;
                    if (element < arr[middle])
                    {
                        Search(arr, start, middle - 1, element);
                    }
                    else if (element > arr[middle])
                    {
                        Search(arr, middle + 1, end, element);
                    }
                    else
                    {
                        Console.WriteLine("The index of {0} is {1}", element, middle);
                        return;
                    }
                }
            }
            static void Main()
            {
                Console.Write("Size of the array: ");
                int N = int.Parse(Console.ReadLine());
                int[] Arr = new int[N];

                for (int index = 0; index < N; index++)
                {
                    Console.WriteLine("Enter array #" + (index + 1) + ": ");
                    Arr[index] = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter element to search for: ");
                int element = int.Parse(Console.ReadLine());
                Array.Sort(Arr);
                Search(Arr, 0, Arr.Length, element);
            }
        }
    }
}