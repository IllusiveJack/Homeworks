using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string a;
            string b;
            string c;

            double num = 1000;
            do
            {
                Console.Write("Please enter the first number(-1000 and 1000): ");
                a = Console.ReadLine();
            }
            while (!double.TryParse(a, out num));

            do {
                Console.Write("Please enter the second number(-1000 and 1000): ");
                b = Console.ReadLine();
               }
            while (!double.TryParse(b, out num));

            do {
                Console.Write("Please enter the third number(-1000 and 1000): ");
                c = Console.ReadLine();
            }
            while (!double.TryParse(c, out num));

            double sum = Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c);

           Console.WriteLine("The sum is {0} ", sum);
        }
    }
}
