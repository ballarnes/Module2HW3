using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public interface ISweetsProvider
    {
        public void SetAllSweets();
        public Sweets GetRandomSweet();
    }
}
