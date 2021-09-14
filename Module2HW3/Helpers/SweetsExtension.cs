using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public static class SweetsExtension
    {
        public static Sweets FindSweet(this Sweets[] sweets, string name)
        {
            Sweets foundSweet = null;
            for (var i = 0; i < sweets.Length; i++)
            {
                if (sweets[i].Name == name)
                {
                    foundSweet = sweets[i];
                    break;
                }
                else
                {
                    i++;
                }
            }

            return foundSweet;
        }
    }
}
