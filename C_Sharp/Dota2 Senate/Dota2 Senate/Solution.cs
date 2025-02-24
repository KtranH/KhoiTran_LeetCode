using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2_Senate
{
    public class Solution
    {
        public string solve_dota2_senate(string senate)
        {
            Queue<int> queue_radiant = new Queue<int> ();
            Queue<int> queue_dier = new Queue<int> ();
            int n = senate.Length;
            for(int i = 0; i < n; i++)
            {
                if (senate[i] == 'R')
                {
                    queue_radiant.Enqueue (i);
                }    
                else
                {
                    queue_dier.Enqueue (i);
                }    
            }

            while(queue_radiant.Count > 0 && queue_dier.Count > 0)
            {
                int radiant_idx = queue_radiant.Dequeue();
                int dier_idx = queue_dier.Dequeue();
                if(radiant_idx < dier_idx)
                {
                    queue_radiant.Enqueue(radiant_idx + n);
                }    
                else
                {
                    queue_dier.Enqueue(dier_idx + n);
                }    
            }
            return queue_radiant.Count > 0 ? "Radiant" : "Dire";
        }
    }
}
