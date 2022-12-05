using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks
{
    class ToCamelCase
    {
        public static string toCamelCase(string str)
        {
            //convert to chars
            char[] characters = new char[str.Length];

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = str[i];
            }

            //examine characters to see if they are "-" or "_"
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i].ToString() == "-" || characters[i].ToString() == "_")
                {
                    characters[i + 1] = Char.ToUpper(characters[i + 1]);
                    Console.WriteLine("BRUIOAHWR");

                }
            }

            //convert back to string
            str = new string(characters);

            //Remove dashes and underscores
            string[] charsToRemove = new string[] { "-", "_" };
            for (int i = 0; i < charsToRemove.Length; i++)
            {
                str = str.Replace(charsToRemove[i], string.Empty);
            }

            return str;
        }
    
    }
}
