using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Merge_Sorted_Array
{
    internal class Solution
    {
        public void solve_merge_sorted_array(int[] nums1, int m, int[] nums2, int n) {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (j >= 0) {
                if(i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                } 
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }
        }
    }
}
