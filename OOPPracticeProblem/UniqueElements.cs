using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticeProblem
{
    public class UniqueElements
    {
        public int[] GetUniqueElements(int[] arr)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (elementCount.ContainsKey(num))
                    elementCount[num]++;
                else
                    elementCount[num] = 1;
            }
            List<int> uniqueList = new List<int>();
           foreach(KeyValuePair<int, int> kvp in elementCount)
           {
                if (kvp.Value == 1) uniqueList.Add(kvp.Key);
           }
           return uniqueList.ToArray();
        }
    }
}
