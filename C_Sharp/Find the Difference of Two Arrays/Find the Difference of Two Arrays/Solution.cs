using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Difference_of_Two_Arrays
{
    public class Solution
    {
        public IList<IList<int>> solve_find_the_difference_of_two_arrays(int[] nums1, int[] nums2) {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);

            IList<IList<int>> result = new List<IList<int>>();

            IList<int> temp = new List<int>();
            foreach (var item in set1)
            {
                if (!set2.Contains(item))
                {
                    temp.Add(item);
                }
            }
            result.Add(temp);
            temp = new List<int>();
            foreach (var item in set2)
            {
                if (!set1.Contains(item))
                {
                    temp.Add(item);
                }
            }
            result.Add(temp);

            //List<int> list1 = new List<int>();
            //List<int> list2 = new List<int>();

            //list1 = set1.Except(set2).ToList();
            //list2 = set2.Except(set1).ToList();

            //result.Add(list1);
            //result.Add(list2);
            return result;
        }
    }
}
