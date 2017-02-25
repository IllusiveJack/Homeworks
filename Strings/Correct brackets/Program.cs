using System;

namespace Correct_brackets
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the expression: ");
            string str = Console.ReadLine();
            int index;
            int index2;
            bool isCorrect = true;
            int ind = 0;

            while(ind >= 0) 
            {
                index = str.IndexOf('(', ind + 1);
                index2 = str.IndexOf(')', ind + 1);

                if(index2 < index)
                {
                    isCorrect = false;
                }
                
            }

            Console.WriteLine(isCorrect);
        }
    }
}
