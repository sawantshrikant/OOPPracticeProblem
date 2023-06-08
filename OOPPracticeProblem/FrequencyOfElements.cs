using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticeProblem
{
    public class FrequencyOfElements
    {
        public Dictionary<int, int> GetElementFrequencies(int[] arr)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (elementCount.ContainsKey(num))
                    elementCount[num]++;
                else
                    elementCount[num] = 1;
            }

            return elementCount;
        }
    }
}
