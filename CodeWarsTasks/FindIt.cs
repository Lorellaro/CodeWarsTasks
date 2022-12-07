using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks
{
    class FindIt
    {
        public static int find_it(int[] seq)
        {
            for (int i = 0; i < seq.Length; i++)
            {
                int tmpTotalOccurences = 1;
                for (int j = 0; j < seq.Length; j++)
                {
                    if (seq[j] == seq[i] && j != i)
                    {
                        tmpTotalOccurences++;
                    }
                }

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
    }
}
