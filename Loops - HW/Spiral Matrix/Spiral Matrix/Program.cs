using System;

namespace Spiral_Matrix
{
	class Program
	{
		static void Main()
		{
			Console.Write("Please enter the size of the array: ");
			int N = int.Parse(Console.ReadLine());
			int[] array = new int[N];

			for (int i = 0; i < N; i++)
			{
				Console.WriteLine(N*i);
			}
		}
	}
}
