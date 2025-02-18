using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Row_and_Column_Pairs
{
    public class Solution
    {
        public int solve_equal_row_and_column_pairs(int[][] grid)
        {
            Dictionary<string, int> hashmap = new Dictionary<string, int>();
            int count = 0;
            int length_grid = grid.Length;

            for (int i = 0; i < length_grid; i++)
            {
                string rowKey = string.Join(",", grid[i]);
                if (hashmap.ContainsKey(rowKey))
                    hashmap[rowKey] += 1;
                else
                    hashmap[rowKey] = 1;
            }

            for (int i = 0; i < length_grid; i++)
            {
                int[] column = new int[length_grid];
                for (int j = 0; j < length_grid; j++)
                    column[j] = grid[j][i];

                string colKey = string.Join(",", column);
                if (hashmap.ContainsKey(colKey))
                    count += hashmap[colKey];
            }

            return count;
        }
    }
}
