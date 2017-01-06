using System;

using System;
using System.Numerics;

class BinaryToDecimalNumber
{
	static void Main()
	{
		string line;
		BigInteger numberInBin = 0;
		BigInteger numberInDec = 0;
		BigInteger bitValue = 0;
		while (true) // Loop indefinitely
		{
			Console.WriteLine("Enter input:"); // Prompt
			line = Console.ReadLine(); // Get string from user
			if (line == "exit") // Check string
			{
				break;
			}
			numberInBin = BigInteger.Parse(line);
			int bitPos = 0;
			while (bitPos < line.Lengths
			{
				bitValue = numberInBin % 10;
				numberInBin = numberInBin / 10;
				numberInDec = numberInDec + bitValue * ((BigInteger)Math.Pow(2, bitPos));
				bitPos++;
			}
			Console.WriteLine(numberInDec);
			numberInDec = 0;
		}
	}
}
