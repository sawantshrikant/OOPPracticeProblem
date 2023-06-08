using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOPPracticeProblem
{
    public class DuplicateElements
    {
        public static int CountDuplicateElements(int [] arr)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int> ();
            foreach (int num in arr)
            {
                if(elementCount.ContainsKey(num))
                    elementCount[num]++;
                else
                    elementCount[num] = 1;
            }
            int duplicateCount = elementCount.Count(X => X.Value > 1);
            return duplicateCount;  
        }
    }
}
