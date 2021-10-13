using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClassLibrary
{
    public class HangmanMethodRepository
    {
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

        public int numGuesses = 6;
        public void EvaluateGuess(string wordToGuess, string guess)
        {
            if (wordToGuess == guess)
            {
                Console.Clear();
                HangmanConstructor(numIncorrect);

                Console.WriteLine("cake", "hello", "abroad", "tree", "keys", "dog", "rain", "gravel");

                Console.WriteLine("You are correct -- Game Over! \n" +
                    "Prerss any key to exit.");
                Console.ReadKey();
                Environment.Exit(1);
            }
            else
            {
                Console.Clear();
                numIncorrect = ++numIncorrect;
                numGuesses = --numGuesses;

                Console.WriteLine("You are wrong");
                Console.WriteLine($"You have {numGuesses} guesses left.");
            }
        }

        public string TakeUserGuess()
        {
            HangmanConstructor(numIncorrect);
            Console.WriteLine("Guess your word:");
            Console.WriteLine("cake, " + "hello, " + "abroad, " + "tree, " + "keys, " + "dog, " + "rain, " + "gravel");

            string guess = Console.ReadLine();

            return guess;
        }
        public string SelectWord()
        {
            string[] words = { "cake", "hello", "abroad", "tree", "keys", "dog", "rain", "gravel" };

            Random random = new Random();
            int value = random.Next(0, words.Length);

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

                    Console.WriteLine("You Loose -- game Over! \n" +
                        "Prerss any key to exit.");
                    Console.ReadKey();
                    Environment.Exit(1);
            }
        }
    }
}
