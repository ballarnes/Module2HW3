using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class SweetsService : ISweetsService
    {
        public string GetRandomName()
        {
            string[] vowels = { "a", "e", "u", "o", "i", "y" };
            string[] consonants = { "b", "d", "r", "z", "p", "h" };
            StringBuilder randomName = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                int randomVowel = new Random().Next(0, 6);
                int randomConsonant = new Random().Next(0, 6);
                if (i == 0)
                {
                    randomName.Append(consonants[randomVowel].ToUpper()).Append(vowels[randomConsonant]);
                }
                else
                {
                    randomName.Append(consonants[randomVowel]).Append(vowels[randomConsonant]);
                }
            }

            return randomName.ToString();
        }

        public string GetRandomColor()
        {
            string[] colors = { "red", "green", "blue", "yellow", "orange", "purple" };
            return colors[new Random().Next(0, 6)];
        }
    }
}
