using System;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            double parameter;
            do
            {
                parameter = double.Parse(Console.ReadLine());
            } while (parameter <= 0);


            double area = parameter * 3.14 * parameter;
            double perimeter = parameter * 2 * 3.14;

            Console.WriteLine(area.ToString("#.00"));
            Console.WriteLine(perimeter.ToString("#.00"));
        }
    }
}
