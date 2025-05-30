using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station
{
    internal class Solution
    {
        public int solve_gasStation(int[] gas, int[] cost)
        {
            int start = 0;
            int tank = 0;
            int totalGas = 0;
            int totalCost = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                totalGas += gas[i];
                totalCost += cost[i];
            }
            if (totalGas < totalCost)
                return -1;
            else
            {
                for (int i = 0; i < gas.Length; i++)
                {
                    tank += gas[i] - cost[i];
                    if (tank < 0)
                    {
                        start = i + 1;
                        tank = 0;
                    }
                }
                return start;
            }    
        }
    }
}
