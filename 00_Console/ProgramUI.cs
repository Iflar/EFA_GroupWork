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
            Console.WriteLine("Welcome, Are you ready to play: Hangman! \n" +
                "           Press Enter to continue...");

            Console.ReadKey();

            Console.Clear();

            string wordToGuess = _repo.SelectWord();

            int life = 0;

            while(life < 6)
            {
                string guess = _repo.TakeUserGuess();

                _repo.EvaluateGuess(wordToGuess, guess);
            }
        }
    }
}
