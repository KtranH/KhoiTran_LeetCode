using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array_II
{
    internal class Solution
    {
        public int solve_remove_duplicates(int[] nums)
        {
            int n = nums.Length;
            if(n <= 2)
            {
                return n;
            }    
            int insert_pos = 2;
            for(int i = 2; i < n; i++)
            {
                if(nums[i] != nums[insert_pos - 2])
                {
                    nums[insert_pos] = nums[i];
                    insert_pos++;
                }
            }    
            return insert_pos;
        }
    }
}
