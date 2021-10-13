using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClassLibrary
{
    public class HangmanMethodRepository
    {
        public void GuessWord()
        {

        }

        public void ConvertWordTobool()
        {

        }

        private readonly Random _randomNum = new Random();

        public int RandomNumber(int min, int max)
        {
            return _randomNum.Next(min, max);
        }

        public void WordsToLists()
        {
            List<string> helloLetters = new List<string>()
            {
                "h",
                "e",
                "l",
                "l",
                "o"
            };

            List<string> cakeLetters = new List<string>()
            {
                "c",
                "a",
                "k",
                "e"
            };

            List<string> treeLetters = new List<string>()
            {
                "a",
                "b",
                "r",
                "o",
                "a",
                "d"
            };
        }
        public int numIncorrect = 0;
        public void EvauateGuess(string wordToGuess, string guess)
        {
            switch (wordToGuess)
            {
                case "cake":
                    WordIsCake(wordToGuess);
                    break;

                case "hello":
                    WordIsHello(wordToGuess);
                    break;

                case "abroad":
                    WordIsAbroad(wordToGuess);
                    break;

                default: break;
            }
            if (wordToGuess == guess)
            {
                Console.Clear();
                HangmanConstructor(numIncorrect);

                Console.WriteLine("You are correct");
            }
            else
            {
                Console.Clear();
                numIncorrect = ++numIncorrect;
                HangmanConstructor(numIncorrect);

                Console.WriteLine("You are wrong");
            }
        }

        public void WordIsCake(string wordToGuess)
        {

        }

        public void WordIsHello(string wordToGuess)
        {

        }

        public void WordIsAbroad(string wordToGuess)
        {

        }

        public string TakeUserGuess()
        {
            Console.WriteLine("Guess your letter:");

            string guess = Console.ReadLine();

            return guess;
        }

        public string SelectWord()
        {
            string[] words = { "cake", "hello", "abroad" };

            Random random = new Random();
            int value = random.Next(0, words.Length);

            Console.WriteLine(words[value]);

            return words[value];
        }
        public void HangmanConstructor(int numIncorrect)
        {
            if (numIncorrect == 0)
            {
                Console.WriteLine("                __________________ \n" +
                    "                ||/             | \n" +
                    "                ||\n" +
                    "                ||\n" +
                    "                ||\n" +
                    "                ||\n" +
                    "                ||\n" +
                    "            ____||________________");
            }

            if (numIncorrect == 1)
            {
                Console.WriteLine("                __________________ \n" +
                    "                ||/             | \n" +
                    "                ||            (-_-)\n" +
                    "                ||\n" +
                    "                ||\n" +
                    "                ||\n" +
                    "                ||\n" +
                    "            ____||________________");
            }

            if (numIncorrect == 2)
            {
                Console.WriteLine("                __________________ \n" +
                    "                ||/             | \n" +
                    "                ||            (-_-)\n" +
                    "                ||             [|]\n" +
                    "                ||\n" +
                    "                ||\n" +
                    "                ||\n" +
                    "            ____||________________");
            }

            if (numIncorrect == 3)
            {
                Console.WriteLine("                __________________ \n" +
                    "                ||/             |             \n" +
                    "                ||            (-_-)           \n" +
                    "                ||           --[|]             \n" +
                    "                ||                          \n" +
                    "                ||                             \n" +
                    "                ||                              \n" +
                    "            ____||________________");
            }

            if (numIncorrect == 4)
            {
                Console.WriteLine("                __________________ \n" +
                    "                ||/             |     \n" +
                    "                ||            (-_-)     \n" +
                    "                ||           --[|]--       \n" +
                    "                ||\n" +
                    "                ||\n" +
                    "                ||\n" +
                    "            ____||________________");
            }

            if (numIncorrect == 5)
            {
                Console.WriteLine("                __________________ \n" +
                    "                ||/             |       \n" +
                    "                ||            (-_-)      \n" +
                    "                ||           --[|]--    \n" +
                    "                ||            _|       \n" +
                    "                ||\n" +
                    "                ||\n" +
                    "            ____||________________");
            }

            if (numIncorrect == 6)
            {
                Console.WriteLine("                __________________ \n" +
                    "                ||/             |     \n" +
                    "                ||            (-_-)     \n" +
                    "                ||           --[|]--   \n" +
                    "                ||            _| |_    \n" +
                    "                ||\n" +
                    "                ||\n" +
                    "            ____||________________");
            }
        }
    }
}
