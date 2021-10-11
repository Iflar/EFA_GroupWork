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


    }
}
