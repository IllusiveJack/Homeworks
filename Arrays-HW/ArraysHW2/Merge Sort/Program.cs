using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter the value of array #" + (arr[i] + 1) + ": ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0}, ", arr[i]);
        }
    }
}
