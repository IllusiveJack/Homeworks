using System;

namespace Index_of_letters
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();

            char[] arr;
            arr = str.ToCharArray();
            char[] alphabet = new char[25];

            for (int i = 0; i < alphabet.Length ; i++)
            {
                alphabet[i] = (char)('a' + i);
            }
           

            foreach(char letter in arr)
            {
                for(int k = 0; k < alphabet.Length; k++)
                {
                    if(letter == alphabet[k])
                    {
                        Console.WriteLine("The index of '{0}' is {1}", letter, k);
                    }
                }
            }
        }
    }
}
