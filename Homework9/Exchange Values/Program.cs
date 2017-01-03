using System;



namespace Exchange_Values
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please input the first value: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please input the second value: ");
            double b = double.Parse(Console.ReadLine());

            if(a > b)
                Console.WriteLine(b + " " + a);
            else
                Console.WriteLine(a + " " + b);
        }
    }
}
