using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multiple.Algoriths
{
    public class Permutations
    {


        public static IList<IList<int>> PermutateArrayList(int[] nums, int start, int end, IList<IList<int>> list)
        {

            if (start == end)
            {
                //I added int[] to list it did not work as it is reference to num, as and when I reswap, they number goes back to original.
                //So I had to add the way that is mentioned below, so as for the permutation to work.
                //I believe a copy of an array is made, what I assign it this way, rather than reference type.
                list.Add(new List<int>(nums));
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    Swap(ref nums[start], ref nums[i]);
                    PermutateArrayList(nums, start + 1, end, list);
                    Swap(ref nums[start], ref nums[i]);
                }
            }

            return list;
        }
        public static IList<IList<int>> DoPermute(int[] nums, int start, int end, IList<IList<int>> list)
        {
            if (start == end)
            {
                // We have one of our possible n! solutions,
                // add it to the list.
                list.Add(new List<int>(nums));
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    //Swap(ref nums[start], ref nums[i]);
                    (nums[start], nums[i]) = (nums[i], nums[start]);
                    DoPermute(nums, start + 1, end, list);
                    (nums[start], nums[i]) = (nums[i], nums[start]);
                    //Swap(ref nums[start], ref nums[i]);
                }
            }

            return list;
        }
        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
    }
}
