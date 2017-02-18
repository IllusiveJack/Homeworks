using System;

namespace Triangle_Surface_by_Side_and_Altitude
{
    class Program
    {
        static void Main()
        {
            Triangle A = new Triangle();

            Console.Write(@"
1. Calculate the Surface based on a length and its height
2. Calculate the Surface based on the three sides
3. Calculate the Surface based on two sides and the anglee between them
Choose an option:");
            string choice = Console.ReadLine();

            if(Convert.ToInt32(choice) == 2)
            {
                Console.Write("Enter the side: ");
                A.A = double.Parse(Console.ReadLine());
                Console.Write("Enter the height: ");
                A.H = double.Parse(Console.ReadLine());
                A.Surface();
            }
            else if(Convert.ToInt32(choice) == 2)
            {
                Console.Write("Enter side A: ");
                A.A = double.Parse(Console.ReadLine());
                Console.Write("Enter side B: ");
                A.B = double.Parse(Console.ReadLine());
                Console.Write("Enter side C: ");
                A.C = double.Parse(Console.ReadLine());
                A.SurfaceByThreeSides();
            }
            else if(Convert.ToInt32(choice) == 3)
            {
                Console.Write("Enter side A: ");
                A.A = double.Parse(Console.ReadLine());
                Console.Write("Enter the angle between A and B: ");
                A.Angle = int.Parse(Console.ReadLine());
                Console.Write("Enter side B: ");
                A.B = double.Parse(Console.ReadLine());
                A.SurfaceByTwoSidesAndAnAngle();
            }
            else
            {
                Console.WriteLine("Invalid input. Start the program and try again.");
            }
        }
    }
}
