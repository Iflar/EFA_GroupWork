using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClassLibrary
{
   public enum letter {
        H = 1,
        E,
        L,
        O}
    public class HangmanObject
    {
        public letter LetterOne { get; set; }
        public letter LetterTwo { get; set; }
        public letter LetterThree { get; set; }
        public letter LetterFour { get; set; }
        public letter LetterFive { get; set; }
        public HangmanObject()
        {

        }

        public HangmanObject(letter firstLetter, letter secondLetter, letter thirdLetter, letter fourthLetter, letter fithLetter)
        {
            LetterOne = firstLetter;
            LetterTwo = secondLetter;
            LetterThree = thirdLetter;
            LetterFour = fourthLetter;
            LetterFive = fithLetter;
        }
    }
}
