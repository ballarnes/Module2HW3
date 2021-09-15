using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public interface IGiftService
    {
        public int GetWeight(Sweets[] sweets);
        public void SortSweetsInTheGiftBox(Sweets[] sweets);
    }
}
