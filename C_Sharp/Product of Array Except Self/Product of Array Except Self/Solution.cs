using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_of_Array_Except_Self
{
    public class Solution
    {
        public int[] slove_product_of_array_except_self(int[] nums)
        {
            int[] result = new int[nums.Length];
            int pre_i = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                result[i] = pre_i;
                pre_i *= nums[i];
            }
            int after_i = 1;
            for(int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= after_i;
                after_i *= nums[i];
            }
            return result;
        }
    }
}
