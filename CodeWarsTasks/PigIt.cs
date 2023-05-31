using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks
{
    class PigIt
    {
        public static string PigItUp(string str)
        {
            //convert str into a list of words
            List<string> listOfWords = new List<string>();

            int firstLetterIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (c.ToString() == " ")
                {
                    //add word needs to be i+1 for last word 
                    string wordToAdd = str.Substring(firstLetterIndex, i - firstLetterIndex);
                    listOfWords.Add(wordToAdd);
                    firstLetterIndex = i + 1;
                }

                if (i == str.Length - 1)
                {
                    string wordToAdd = str.Substring(firstLetterIndex, i - firstLetterIndex + 1);
                    listOfWords.Add(wordToAdd);
                }
            }

            List<string> listOfNewWords = new List<string>();

            for (int i = 0; i < listOfWords.Count; i++)
            {
                //move the p to the end
                string newWord = listOfWords[i];
                string removedLetter = newWord[0].ToString();
                newWord = newWord.Substring(1);
                newWord += removedLetter;
                //add ay to the end
                if (!char.IsPunctuation(newWord[0]))
                {
                    newWord += "ay ";
                }

                if (i == listOfWords.Count - 1)
                {
                    newWord = newWord.Trim();
                }

                listOfNewWords.Add(newWord);
            }

            return string.Join("", listOfNewWords);
        }
    }
}
