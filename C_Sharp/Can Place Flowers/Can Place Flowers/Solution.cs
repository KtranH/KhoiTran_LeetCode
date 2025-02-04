using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Can_Place_Flowers
{
    public class Solution
    {
        public bool solve_can_place_flowers(int[] flowerbed, int n)
        {
            int count = 0;
            for(int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    count++;
                    flowerbed[i] = 1;
                    if(count >= n)
                    {
                        return true;
                    }    
                }    
            }    
            return count >= n ? true : false;
        }
    }
}
