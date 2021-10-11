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
            CreateWord();
            RunGame();
        }
        //Console.Clear();
        private void RunGame()
        {
            Console.WriteLine("Welcome, Are you redy to play: Hnagmamn! \n" +
                "           Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("It worked!");

            Console.ReadKey();
        }

        private void CreateWord()
        {
            HangmanObject wordToGuess = new HangmanObject(letter.H, letter.E, letter.L, letter.L, letter.O);
            _repo.AddWord(wordToGuess);
        }

    }
}
