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


            // TESTS ------------------
            // ------------------------
            // ------------------------
            // Uncomment to try out functionality


            /*
            int[] arr = { 5, 3, 2, 8, 1, 4 };
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(SortArrayOddNum.sortArrayOddNum(arr)[i] + ", ");
            }
            Console.ReadLine();
            */

            /*
            string camelCase = "the-stealth-warrior";
            string upperCamelCase = "The_Stealth_Warrior";

            camelCase = ToCamelCase.toCamelCase(camelCase);
            upperCamelCase = ToCamelCase.toCamelCase(upperCamelCase);

            Console.WriteLine(camelCase);
            Console.WriteLine(upperCamelCase);
            Console.ReadLine();
            */

            
            int[] arr = {  20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5  };
            Console.WriteLine(FindIt.find_it(arr));
            Console.ReadLine();
            

            /*
            int[] arr = { 0, 1, 2, 3, 4 };
            int target = 3;

            int[] twoSums = TwoSum.twoSum(arr, target);
            for (int i = 0; i < twoSums.Length; i++)
            {
                Console.Write(twoSums[i] + ", ");
            }

            Console.ReadLine();
            */
            
            /*
            int x = 151;
            Console.WriteLine(CountBits.countBits(x));
            Console.ReadLine();
            */

            /*
            string x = "Hey fellow warriors";
            Console.WriteLine(SpinWords.spinWords(x));
            Console.ReadLine();
            */
        }
    }
}
