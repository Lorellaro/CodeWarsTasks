using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks
{
    class SortArrayOddNum
    {

        //sort odd leave others in their positions
        public static int[] sortArrayOddNum(int[] array)
        {
            List<int> oddNumArr = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)//if odd
                {
                    oddNumArr.Add(array[i]);
                }
            }

            oddNumArr.Sort();
            int oddIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                //add in the leftovers
                if (array[i] % 2 == 1)//if odd
                {
                    array[i] = oddNumArr[oddIndex];
                    oddIndex++;
                }

            }

            return array;
        }
    }
}
