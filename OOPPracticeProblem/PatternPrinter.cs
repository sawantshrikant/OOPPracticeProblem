using System;

namespace OOPPracticeProblem
{
    public class PatternPrinter
    {
        public void PrintPattern(int numRows)
        {
            for (int i = numRows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
