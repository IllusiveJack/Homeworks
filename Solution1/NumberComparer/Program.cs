using System;

namespace NumberComparer
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double b = double.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine(a);
            }
            else if(a < b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
