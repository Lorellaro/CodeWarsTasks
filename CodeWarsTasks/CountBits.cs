using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks
{
    class CountBits
    {
        /*
         * Write a function that takes an integer as input, 
         * and returns the number of bits that are equal to one in the binary representation of that number. 
         * You can guarantee that input is non-negative.

            Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case
        */

        public static int countBits(int n)
        {
            //Convert int to base 2
            string tmpNum = n.ToString();
            string binaryEquivalent = Convert.ToString(Convert.ToInt32(tmpNum, 10), 2);

            char[] charArr = binaryEquivalent.ToCharArray();
            int oneCount = 0;

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == Char.Parse("1"))
                {
                    oneCount++;
                }
            }

            //Count 1s - return it
            return oneCount;
        }
    }
}
