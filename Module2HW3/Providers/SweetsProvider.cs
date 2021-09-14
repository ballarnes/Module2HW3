using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class SweetsProvider : ISweetsProvider
    {
        private readonly Sweets[] _allSweets = new Sweets[40];
        public void SetAllSweets()
        {
            var sweetsService = new SweetsService();
            for (int i = 0; i < 10; i++)
            {
                int stuffed = new Random().Next(0, 1);
                _allSweets[i] = new SweetsWithoutNuts() { Name = sweetsService.GetRandomName(), Weight = new Random().Next(8, 15), CocoaPercentage = new Random().Next(30, 41), MilkPowderPercentage = new Random().Next(20, 31), IsStuffed = Convert.ToBoolean(stuffed) };
            }

            for (int i = 10; i < 20; i++)
            {
                int bitter = new Random().Next(0, 1);
                _allSweets[i] = new SweetsWithHazelnut() { Name = sweetsService.GetRandomName(), Weight = new Random().Next(15, 21), CocoaPercentage = new Random().Next(50, 71), NutsPercentage = new Random().Next(15, 26), IsBitter = Convert.ToBoolean(bitter) };
            }

            for (int i = 20; i < 30; i++)
            {
                _allSweets[i] = new CaramelSweets() { Name = sweetsService.GetRandomName(), Weight = new Random().Next(6, 11), DyeColor = sweetsService.GetRandomColor() };
            }
        }

        public Sweets GetRandomSweet()
        {
            Sweets sweet = _allSweets[new Random().Next(0, 30)];
            return sweet;
        }
    }
}
