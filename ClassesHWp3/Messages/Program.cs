using System;

namespace Messages
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first number of the system: ");
            string NumberA = Console.ReadLine();
            Console.Write("Enter the operator: ");
            char Operator = char.Parse(Console.ReadLine());
            Console.Write("Enter the second number of the system: ");
            string NumberB = Console.ReadLine();

            Translator Tr1 = new Translator();
            Tr1.Operator = Operator;
            Tr1.StringCutter(NumberA, Tr1.NumberAt = new int[NumberA.Length / 3]);
            Tr1.StringCutter(NumberB, Tr1.NumberBt = new int[NumberB.Length / 3]);
            Tr1.IntToStringValue();

        }
    }

    class Translator
    {
        private int Result;

        public int[] NumberAt;
        public int[] NumberBt;

        public string NumberA { get; set; }
        public char Operator { get; set; }
        public string NumberB { get; set; }

        public void StringCutter(string Number, int[] num)
        {
            int ChunkSize = 3;
            int STRLength = num.Length;
            for (int i = 0; i < STRLength; i++)
            {
                ArrayFiller(ChunkSize, i, Number, num);
            }
        }

        private void ArrayFiller(int ChunkSize, int i, string Number, int[] num)
        {
            int p = i;
            if (i > 0)
            {
                p += 2 * i;
            }
            string CurrentString = Number.Substring(p, ChunkSize);

            if (CurrentString == "cad")
            {
                num[i] = 0;
            }
            else if (CurrentString == "xoz")
            {
                num[i] = 1;
            }
            else if (CurrentString == "nop")
            {
                num[i] = 2;
            }
            else if (CurrentString == "cyk")
            {
                num[i] = 3;
            }
            else if (CurrentString == "min")
            {
                num[i] = 4;
            }
            else if (CurrentString == "mar")
            {
                num[i] = 5;
            }
            else if (CurrentString == "kon")
            {
                num[i] = 6;
            }
            else if (CurrentString == "iva")
            {
                num[i] = 7;
            }
            else if (CurrentString == "ogi")
            {
                num[i] = 8;
            }
            else if (CurrentString == "yan")
            {
                num[i] = 9;
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }

        private int ArraytoNum(int[] num)
        {
            int finalScore = 0;
            int multipicator = 1;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                int CurrentNum = num[i] * multipicator;
                finalScore += CurrentNum;
                multipicator *= 10;
            }
            return finalScore;
        }

        public void Calculator()
        {
            int num1 = ArraytoNum(NumberAt);
            int num2 = ArraytoNum(NumberBt);

            if (Operator == '+')
            {
                Result = num1 + num2;
            }
            else if (Operator == '-')
            {
                Result = num1 - num2;
            }
            else if (Operator == '*')
            {
                Result = num1 * num2;
            }
            else if (Operator == '/')
            {
                Result = num1 / num2;
            }
            else if (Operator == '%')
            {
                Result = num1 % num2;
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }

        public void IntToStringValue()
        {
            Calculator();
            string Output = "";
            string Res = Convert.ToString(Result);
            int[] Resul = new int[Res.Length];

            for (int i = 0; i < Res.Length; i++)
            {
                Resul[i] = Convert.ToInt32(Res.Substring(i, 1));
            }

            for (int i = 0; i < Res.Length; i++)
            {
                switch (Resul[i])
                {
                    case 0:
                        Output += "cad";
                        break;
                    case 1:
                        Output += "xoz";
                        break;
                    case 2:
                        Output += "nop";
                        break;
                    case 3:
                        Output += "cyk";
                        break;
                    case 4:
                        Output += "min";
                        break;
                    case 5:
                        Output += "mar";
                        break;
                    case 6:
                        Output += "kon";
                        break;
                    case 7:
                        Output += "iva";
                        break;
                    case 8:
                        Output += "ogi";
                        break;
                    case 9:
                        Output += "yan";
                        break;
                    default:
                        Console.WriteLine("GTFO");
                        break;
                }
            }
            Console.Write("{0} ", Output);
        }
    }
}
