using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        Console.Write("Please enter the first array: ");
        string array1 = Console.ReadLine();
        Console.Write("Please enter the second array: ");
        string array2 = Console.ReadLine();
        int sum1 = 0;
        int sum2 = 0;

        array1.ToCharArray();
        array2.ToCharArray();
        int[] ar1 = new int[array1.Length];
        int[] ar2 = new int[array2.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            ar1[i] = Convert.ToInt32(array1[i]);
            sum1 += ar1[i];
        }
        for (int j = 0; j < array2.Length; j++)
        {
            ar2[j] = Convert.ToInt32(array2[j]);
            sum2 += ar2[j];
        }

      
        if (sum1 > sum2)
        {
            Console.WriteLine(">");
        }
        else if (sum1 < sum2)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("=");
        }
    }
}