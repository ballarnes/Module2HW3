using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class ConsoleOutputService
    {
        public void NamesOutput(Sweets[] sweets)
        {
            var giftService = new GiftService();
            string[] name = giftService.GetRandomSweetsNames(sweets);
            Console.WriteLine("Three random sweets names: ");
            for (var i = 0; i < name.Length; i++)
            {
                Console.Write($"{name[i]} ");
            }

            Console.WriteLine();
        }

        public void WeightOutput(Sweets[] sweets)
        {
            var giftService = new GiftService();
            var totalWeight = giftService.GetWeight(sweets);
            Console.WriteLine($"Total weight of sweets in the gift: {totalWeight}g");
        }

        public void FoundedSweetOutput(Sweets foundedSweet)
        {
            if (foundedSweet != null)
            {
                Console.WriteLine("The sweet has been founded!");
                Console.WriteLine($"Sweet's name: {foundedSweet.Name}, sweet's weight: {foundedSweet.Weight}g");
            }
            else
            {
                Console.WriteLine("I can't find the sweet with that name..");
            }
        }
    }
}
