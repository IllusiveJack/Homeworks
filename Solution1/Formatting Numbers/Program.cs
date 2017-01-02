using System;

namespace Formatting_Numbers
{
    class Program
    {
        static void Main()
        {
            int a;
            float b;
            float c;


            Console.Write("Please enter the value of the frist number. >0 and <500: ");
            do
            {
                a = int.Parse(Console.ReadLine());
            } while (a <= 0 && a >= 500);
            Console.Write("Please enter the value of the second number: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Please enter the value of the third number: ");
            c = float.Parse(Console.ReadLine());

            string HEXa = a.ToString("X");
            string BINb = Convert.ToString(a, 2);

            Console.WriteLine(HEXa);
            Console.WriteLine(BINb);
            Console.WriteLine(b.ToString("#.00"));
            Console.WriteLine(c.ToString("#.000"));


        }
    }
}
