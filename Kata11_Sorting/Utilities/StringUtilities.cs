using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata11_Sorting_Part2.Function
{
    static class StringUtilities
    {
        public static void MySort(string inputString)
        {
            string cleanedString = Clean(inputString);
            List<char> chars = cleanedString.ToList();

            //applied bubble sort algorithm, but
            //an other solution could considers char as bytes:
            //saving each char as an array of byte (each char stored as byte) and a loop
            //that prints 0x60, 0x61 (with 0xY increased at each cycle)
            for (int j = 0; j <= cleanedString.Length - 2; j++)
            {
                for (int i = 0; i <= cleanedString.Length - 2; i++)
                {
                    if (chars[i] > chars[i + 1])
                    {
                        char temp = chars[i + 1];
                        chars[i + 1] = chars[i];
                        chars[i] = temp;
                    }
                }
            }

            Console.Write("Sorted string: ");
            foreach (char c in chars)
            { Console.Write(c); }
        }

        public static string Clean(string stringToClean)
        {
            stringToClean = stringToClean.ToLower();
            stringToClean = stringToClean.Replace(" ", "");
            stringToClean = stringToClean.Replace(".","");
            stringToClean = stringToClean.Replace(",", "");
            stringToClean = stringToClean.Replace("!", "");
            stringToClean = stringToClean.Replace(",", "");
            stringToClean = stringToClean.Replace(",", "");
            stringToClean = stringToClean.Replace("(", "");
            stringToClean = stringToClean.Replace(")", "");
            stringToClean = stringToClean.Replace("?", "");
            stringToClean = stringToClean.Replace("'", "");
            stringToClean = stringToClean.Replace("$", "");
            stringToClean = stringToClean.Replace("%", "");
            stringToClean = stringToClean.Replace("&", "");
            stringToClean = stringToClean.Replace("/", "");

            string cleanedString = stringToClean;
            return cleanedString;
        }
            
    }
}
