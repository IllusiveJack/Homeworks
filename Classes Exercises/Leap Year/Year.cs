using System;

namespace Leap_Year
{
    public class Year
    {
        public int numbers;

        public int GetSetYear{ get; set; }

        public void IsLeap(int numbers)
        {
            if( numbers % 400 == 0)
            {
                Console.WriteLine("Leap");
            }
            else if(numbers % 100 == 0)
            {
                Console.WriteLine("Common");
            }
            else if(numbers % 4 == 0)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }

    }
}
