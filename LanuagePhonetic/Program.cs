using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanuagePhonetic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] letters = new string[,]
            {
                {"a", "ah" },
                {"b", "bay" },
                {"c", "say" },
                {"d", "day" },
                {"e", "euh" },
                {"f", "eff" },
                {"g", "zhay" },
                {"h", "ash" },
                {"i", "ee" },
                {"j", "zhee" },
                {"k", "kah" },
                {"l", "ell" },
                {"m", "em" },
                {"n", "en" },
                {"o", "oh" },
                {"p", "pay" },
                {"q", "coo" },
                {"r", "err" },
                {"s", "ess" },
                {"t", "tay" },
                {"u", "u" },
                {"v", "vay" },
                {"w", "doob-leh-vay" },
                {"x", "eeks" },
                {"y", "ee-grek" },
                {"z", "zed" }
            };

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-----------------------\nFrench phonetic speller\n-----------------------");
            Console.ResetColor();
            
            string word = "";
            string phoneticSpelling = "";

            while (word != "q")
            {
                Console.Write("Enter the word(q to quit): ");
                word = Console.ReadLine().ToLower();
                phoneticSpelling = "";

                if (word != "q")
                {
                    foreach (char character in word)
                    {
                        for (int i = 0; i < letters.GetLength(0); i++)
                        {
                            if (Char.Parse(letters[i, 0]) == character)
                            {
                                phoneticSpelling += letters[i, 1];

                                if (character != word.Last())
                                {
                                    phoneticSpelling += "-";
                                }
                            }
                        }
                    }

                    Console.WriteLine(phoneticSpelling + "\n");
                }
            }

            Console.ReadLine();
        }
    }
}
