using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClassLibrary
{
   public enum word {
        hello,
        cake,
        tree
    }
    public class HangmanObject
    {
        public word wordOne { get; set; }
        public HangmanObject()
        {

        }

        public HangmanObject(word word1)
        {
            wordOne = word1;
        }
    }
}
