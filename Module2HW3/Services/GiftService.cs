using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class GiftService : IGiftService
    {
        public int GetWeight(Sweets[] sweets)
        {
            var totalWeight = 0;
            for (int i = 0; i < sweets.Length; i++)
            {
                totalWeight += sweets[i].Weight;
            }

            return totalWeight;
        }

        public void SortSweetsInTheGiftBox(Sweets[] sweets)
        {
            Array.Sort(sweets, new SweetsComparer());
        }

        public string[] GetRandomSweetsNames(Sweets[] sweets)
        {
            string[] names = new string[3];
            for (var i = 0; i < 3; i++)
            {
                names[i] = sweets[new Random().Next(0, 40)].Name;
            }

            return names;
        }
    }
}
