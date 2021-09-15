using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class SearchByNameService : SearchService
    {
        public override Sweets Search(Sweets[] sweets, string name)
        {
            Sweets foundSweet = sweets.FindSweet(name);
            return foundSweet;
        }
    }
}
