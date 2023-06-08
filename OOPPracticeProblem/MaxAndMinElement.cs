using System;

namespace OOPPracticeProblem
{
    public class MaxAndMinElement
    {
        public int FindMaximum(int[] arr)
        {
            int max = int.MinValue;
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        public int FindMinimum(int[] arr)
        {
            int min = int.MaxValue;
            foreach (int num in arr)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }
    }
}
