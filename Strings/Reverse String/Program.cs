using System;

namespace Reverse_String
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Reverser(str);
        }

        static void Reverser(string str)
        {
            char[] array = str.ToCharArray();

            Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}
