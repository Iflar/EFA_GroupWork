using _01_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Console
{
    class ProgramUI
    {
        private readonly HangmanMethodRepository _repo = new HangmanMethodRepository();
        public void Run()
        {
            
            RunGame();
        }
        //Console.Clear();
        private void RunGame()
        {
            Console.WriteLine("Welcome, Are you redy to play: Hangman! \n" +
                "           Press Enter to continue...");

            Console.ReadKey();

            Console.Clear();

            SelectWord();

            if (SelectWord() == "hello")
            {
                Console.WriteLine("The word is hello");
            }
            else
            {
                Console.WriteLine("The word is not hello");
            }

            Console.ReadKey();
        }

        public string SelectWord()
        {
            string[] words = { "hello", "cake", "tree" };

            Random random = new Random();
            int value = random.Next(0, words.Length);

            Console.WriteLine(words[value]);

            return words[value];
        }
    }
}
