using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks
{

    /*Write a function that takes in a string of one or more words, 
         * and returns the same string, but with all five or more letter 
         * words reversed (Just like the name of this Kata). 
         * Strings passed in will consist of only letters and spaces. 
         * Spaces will be included only when more than one word is present.

Examples:

spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
spinWords( "This is a test") => returns "This is a test" 
spinWords( "This is another test" )=> returns "This is rehtona test"
*/

    class SpinWords
    {
        public static string spinWords(string sentence)
        {
            string[] wordArray = sentence.Split(Char.Parse(" "));

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i].Length >= 5)
                {
                    //Reverse
                    char[] charArray = wordArray[i].ToCharArray();
                    Array.Reverse(charArray);
                    string newWord = new string(charArray);
                    wordArray[i] = newWord;
                }
            }

            sentence = string.Join(" ", wordArray);

            return sentence;
        }

    }
    
}
