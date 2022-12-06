using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks
{
    class TwoSum
    {
        public static int[] twoSum(int[] numbers, int target)
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
    }
}
