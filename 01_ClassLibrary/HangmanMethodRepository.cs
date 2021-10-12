using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClassLibrary
{
    public class HangmanMethodRepository
    {
        private readonly List<HangmanObject> _wordToGuess = new List<HangmanObject>();
      public bool AddWord(HangmanObject word)
        {
            int startCount = _wordToGuess.Count;
            _wordToGuess.Add(word);
            bool wasAdded = _wordToGuess.Count > startCount ? true : false;
            return wasAdded;
        }

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
        private void CreateListOfWords()
        {
            List<string> words = new List<string>()
            {
                "hello",
                "cake",
                "tree"
            };
        }

        private void WordsToLists()
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
                "t",
                "r",
                "e",
                "e"
            };
        }



    }
}
