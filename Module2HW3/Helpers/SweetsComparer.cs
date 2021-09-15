using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class SweetsComparer : IComparer<Sweets>
    {
        public int Compare(Sweets s1, Sweets s2)
        {
            if (s1.Weight > s2.Weight)
            {
                return 1;
            }
            else if (s1.Weight < s2.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
