using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Transformer(int number)
        {
            int counter = 0;
            int[] binary = new int[number];
            do
            {
                int value = number % 2;

                if (value != 0)
                {
                    binary[counter] = 1;
                }
                else
                {
                    binary[counter] = 0;
                }
                counter++;
                number = number / 2;
            } while (number > 1);

            binary[counter] = 1;

            for (int i = counter + 1; i > 0; i--)
            {
                Console.Write(binary[i]);
            }
        }


        static void Main()
        {
            Console.Write("Enter the number in decimal: ");
            int N = int.Parse(Console.ReadLine());

            Transformer(N);
        }
    }
}
