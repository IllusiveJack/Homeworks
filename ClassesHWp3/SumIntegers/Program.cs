using System;
using System.Linq;

namespace SumIntegers
{
    class Program
    {
        static void Main()
        {
            SUM Sum1 = new SUM();

            Console.Write("Enter the integers separated by space: ");
            Sum1.Nums = Console.ReadLine();

            Sum1.SumFunc();
        }
    }

    class SUM
    {
        public string Nums { get; set; }

        public void SumFunc()
        {
            int[] NumsArr = Nums.Split(' ').Select(int.Parse).ToArray();
            int Sum = 0;
            
            for(int i = 0; i < NumsArr.Length; i++)
            {
                Sum += NumsArr[i];
            }

            Console.WriteLine(Sum);
        }
    }
}
