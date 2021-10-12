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
            int randomNum = _repo.RandomNumber(0, 3);   
            HangmanObject wordToGuess = new HangmanObject(word.hello);
            _repo.AddWord(wordToGuess);
            Console.WriteLine(wordToGuess);
            Console.WriteLine(randomNum);
        }

    }
}
