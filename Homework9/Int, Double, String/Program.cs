using System;

namespace Int__Double__String
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter the type of data: ");
            string typeD = Console.ReadLine();
            Console.Write("Plese enter the value of the data: ");
            string a = Console.ReadLine();

            if( typeD == "integer" || typeD == "int")
            {
                Console.WriteLine(Convert.ToInt32(a) + 1);
            }
            else if (typeD == "real" || typeD == "double")
            {
                Console.WriteLine(Convert.ToDouble(a) + 1);
            }
            else if (typeD == "text" || typeD == "string")
            {
                Console.WriteLine(a + '*');
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
