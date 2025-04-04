using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination_Sum_III
{
    internal class Solution
    {
        public void backtracking(int start, int target, IList<int> path, IList<IList<int>> result, int k) { 
            if(k == path.Count && target == 0) {
                result.Add(path.ToList());
                return;
            }
            if(k == path.Count || target < 0) {
                return;
            }
            for(int i = start; i <= 9; i++) {
                path.Add(i);
                backtracking(i + 1, target - i, path, result, k);
                path.RemoveAt(path.Count - 1);
            }
        }
        public IList<IList<int>> solve_combination_sum_iii(int k, int n) {
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> path = new List<int>();
            backtracking(1, n, path, result, k);
            return result;
        }
    }
}
