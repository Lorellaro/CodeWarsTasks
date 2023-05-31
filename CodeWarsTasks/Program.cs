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
            
            while (true)
            {
                Console.WriteLine("Input text duplicate with spaces");
                string input = Console.ReadLine();

                List<string> result = input.Split(' ').ToList();

                var query = result.GroupBy(x => x)
                  .Where(g => g.Count() > 1)
                  .Select(y => new { Element = y.Key, Counter = y.Count() })
                  .ToList();

                for (int i = 0; i < query.Count; i++)
                {
                    Console.WriteLine(query[i]);
                }

                if(query.Count == 0)
                {
                    Console.WriteLine("None found...");
                }

                Console.WriteLine("Press Enter to restart");
                Console.ReadLine();
            }
            

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

            /*
            int[] arr = {  20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5  };
            Console.WriteLine(FindIt.find_it(arr));
            Console.ReadLine();
            */

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

            /*
            string x = "Hello world !";
            Console.WriteLine(PigIt.PigItUp(x));
            Console.ReadLine();
            */    
        }
    }
}
