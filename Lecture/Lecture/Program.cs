using System;
using System.Linq;
using System.Text;

namespace Lecture
{
    class Program
    {
        static void Main()
        {
            string str = GetString();
            Console.WriteLine(str);
        }

        private static string GetString()
        {
            string input = "Krum, Sasho, Deni";

            StringBuilder sb = new StringBuilder();
            foreach (var item in input)
            {
                if(char.IsUpper(item))
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }
    }
}
