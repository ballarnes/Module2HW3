using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Starter
    {
        public void Run()
        {
            var giftService = new GiftService();
            var giftProvider = new GiftProvider();
            var consoleOutputService = new ConsoleOutputService();
            SearchService search = new SearchByNameService();
            giftProvider.FillInTheGiftBox();
            Sweets[] sweets = giftProvider.GetSweetsFromTheGiftBox();
            giftService.SortSweetsInTheGiftBox(sweets);

            consoleOutputService.NamesOutput(sweets);
            consoleOutputService.WeightOutput(sweets);

            Console.WriteLine("Enter sweet's name to find: ");
            string findSweet = Console.ReadLine();
            Sweets foundSweet = search.Search(sweets, findSweet);
            consoleOutputService.FoundedSweetOutput(foundSweet);
        }
    }
}
