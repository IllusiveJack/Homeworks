using System;

namespace Leap_Year
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a year: ");
            int year = int.Parse(Console.ReadLine());

            Year IsItLeap = new Year();
            IsItLeap.IsLeap(year);
        }
    }
}
