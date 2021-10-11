using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Notes:

            We are making the game Hangman...
            Ruels are simple: One player thinks of a word (the computer in this case) while the other players try to guess it.
            They guess using a single letter at a time, for each letter guessed wrong, a component of the Hangman is added.

            TODO: 

            1. Computer needs to select a word from a list at random.
                - Perhaps we could use an enum?      
                                                                                       1 2 3 4 5          1 2 3 4 5
            2. Count number of letters in the word - display spaces for letters. ex: ( _ _ _ _ _ ) word = h e l l o
                - Store each letter in the word in a list as a character? H being index 1, E index 2, and so on...

            3. Each letter guessed correctly needs to be filled in. ex: guess = L, result: ( _ _ l l _ )
                - This is a bit tricky, I'll think about this one.

            4. Each letter guessed incorectly needs to add to the man. ex: guess = Q, result: ('_')
                - Same here as the last one...
                           
            Full Hangman: ('_')
                           /|\
                           / \

            (Forrest) My ideas before begining:
            
            Choosing the word at random is easy, we just make a lsit of words, count that list (manually), and generate a random number
            from 1 to the number of items (words) in that list. ex: List<string> exampleList = new List<string>{"one", "two", "three"}
            generateRandomNumber(1-3); or something. However, I'd first like to get the program working with just a single word,
            Once we've acomplished that, we can spice it up with some randomness.
             */

            ProgramUI UI = new ProgramUI();
            UI.Run();
        }
    }
}
