using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Provinces
{
    internal class Solution
    {
        public void DFS(int[][] isConnected, bool[] bools, int index)
        {
            if(bools[index])
            {
                return;
            }    
            bools[index] = true;
            for (int i = 0; i < isConnected.Length; i++)
            {
                if (isConnected[index][i] == 1)
                {
                    DFS(isConnected, bools, i);
                }
            }
        }
        public int solve_number_of_provinces()
        {
            int[][] isConnected = new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 1, 0 }, new int[] { 0, 0, 1 } };
            bool[] bools = new bool[isConnected.Length];
            int count = 0;
            for (int i = 0; i < isConnected.Length; i++)
            {
                if (!bools[i])
                {
                    count++;
                    DFS(isConnected, bools, i);
                }
            }    
            return count;
        }
    }
}
