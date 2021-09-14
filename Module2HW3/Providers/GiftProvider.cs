using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class GiftProvider : IGiftProvider
    {
        private readonly Sweets[] _gift = new Sweets[40];
        public void FillInTheGiftBox()
        {
            var sweetsProvider = new SweetsProvider();
            sweetsProvider.SetAllSweets();
            for (var i = 0; i < _gift.Length; i++)
            {
                _gift[i] = sweetsProvider.GetRandomSweet();
            }
        }

        public Sweets[] GetSweetsFromTheGiftBox()
        {
            Sweets[] sweets = _gift;
            return sweets;
        }
    }
}
