using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class MedianOfTwoSortedArray
    {
        public static double FindMedianSortedArraysFailed(int[] nums1, int[] nums2)
        {
            double median1 = -1;
            double median2 = -1;
            
            if (nums1.Length > 0)
            {
                if (nums1.Length % 2 == 0)
                {
                    median1 = ((double)nums1[(nums1.Length / 2) - 1] + (double)nums1[nums1.Length / 2]) / 2;
                }
                else
                {
                    median1 = (double)nums1[nums1.Length / 2];
                }
            }

            if (nums1.Length > 0)
            {
                if (nums2.Length % 2 == 0)
                {
                    median2 = ((double)nums2[(nums2.Length / 2) - 1] + (double)nums2[nums2.Length / 2]) / 2;
                }
                else
                {
                    median2 = (double)nums2[nums2.Length / 2];
                }
            }

            if (median1 == -1 && median2 == -1)
                return 0;
            
            if (median1 == -1)
                return median2;
            

            if (median2 == -1)
                return median1;
            return (median1 + median2) / 2;
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 && nums2.Length == 0)
                return 0;
            List<int> list = new List<int>();
            int i = 0;
            int j = 0;
           

            while (i < nums1.Length && j < nums2.Length)
            {
                
                if (nums1[i] < nums2[j])
                    list.Add(nums1[i++]);
                else
                    list.Add(nums2[j++]);
            }

            
            while (i < nums1.Length)
                list.Add(nums1[i++]);

            
            while (j < nums2.Length)
                list.Add(nums2[j++]);


            if (list.Count%2==0)
                return ((double)list[(list.Count / 2) - 1] + (double)list[list.Count / 2]) / 2;
             else
             {
                return (double)list[list.Count / 2];
            }
        }
    }
    
}
