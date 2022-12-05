using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = { 5, 3, 2, 8, 1, 4 };
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(SortArrayOddNum(arr)[i]);
            }
            Console.ReadLine();
            */

            
            string camelCase = "the-stealth-warrior";
            string upperCamelCase = "The_Stealth_Warrior";

            camelCase = ToCamelCase.toCamelCase(camelCase);
            upperCamelCase = ToCamelCase.toCamelCase(upperCamelCase);

            Console.WriteLine(camelCase);
            Console.WriteLine(upperCamelCase);
            Console.ReadLine();

            /*
            int[] arr = {  20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5  };
            Console.WriteLine(find_it(arr));
            Console.ReadLine();
            /*
            int[] arr = { 0, 1, 2, 3, 4 };
            int target = 3;

            Console.WriteLine(TwoSum(arr, target));
            Console.ReadLine();

            /*
            int x = 151;
            Console.WriteLine(CountBits(x));
            Console.ReadLine();
            */

            /*
            string x = "Hey fellow warriors";
            Console.WriteLine(SpinWords(x));
            Console.ReadLine();
            */
        }

        //sort odd leave others
        public static int[] SortArrayOddNum(int[] array)
        {
            List<int> oddNumArr = new List<int>();
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 1)//if odd
                {
                    oddNumArr.Add(array[i]);
                }
            }

            oddNumArr.Sort();
            int oddIndex = 0;

            for(int i = 0; i < array.Length; i++)
            {
                //add in the leftovers
                if(array[i] % 2 == 1)//if odd
                {
                    array[i] = oddNumArr[oddIndex];
                    oddIndex++;
                }

            }

            return array;
        }

        public static int find_it(int[] seq)
        {
            for(int i = 0; i < seq.Length; i++)
            {
                int tmpTotalOccurences = 1;
                for(int j = 0; j < seq.Length; j++)
                {
                    if(seq[j] == seq[i] && j != i)
                    {
                        tmpTotalOccurences++;
                    }
                }

                Console.WriteLine(tmpTotalOccurences);

                if (tmpTotalOccurences % 2 == 1)
                {
                    return seq[i];
                }//if odd
                //Count occurences of a number
                //modulus by 2 if == 1 then odd
                //return that number
            }

            return -1;
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int index1 = 0;
            int index2 = 0;

            //target - current element if it does not equal another number in the list then return
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target && i != j)
                    {
                        index1 = i;
                        index2 = j;
                    }
                }
            }

            int[] indexes = { index1, index2 };
            return indexes;
        }

        /*
         * Write a function that takes an integer as input, 
         * and returns the number of bits that are equal to one in the binary representation of that number. 
         * You can guarantee that input is non-negative.

            Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case
        */
        public static int CountBits(int n)
        {
            //Convert int to base 2
            string tmpNum = n.ToString();
            string binaryEquivalent = Convert.ToString(Convert.ToInt32(tmpNum, 10), 2);

            char[] charArr = binaryEquivalent.ToCharArray();
            int oneCount = 0;

            for(int i = 0; i < charArr.Length; i++)
            {
                if(charArr[i] == Char.Parse("1"))
                {
                    oneCount++;
                }
            }

            //Count 1s - return it
            return oneCount;
        }



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
        public static string SpinWords(string sentence)
        {
            string[] wordArray = sentence.Split(Char.Parse(" "));

            for(int i = 0; i < wordArray.Length; i++)
            {
                if(wordArray[i].Length >= 5)
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
