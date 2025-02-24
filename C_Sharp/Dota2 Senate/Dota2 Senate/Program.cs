//Example 1:

//Input: senate = "RD"
//Output: "Radiant"
//Explanation:
//The first senator comes from Radiant and he can just ban the next senator's right in round 1. 
//And the second senator can't exercise any rights anymore since his right has been banned. 
//And in round 2, the first senator can just announce the victory since he is the only guy in the senate who can vote.
//Example 2:

//Input: senate = "RDD"
//Output: "Dire"
//Explanation:
//The first senator comes from Radiant and he can just ban the next senator's right in round 1. 
//And the second senator can't exercise any rights anymore since his right has been banned. 
//And the third senator comes from Dire and he can ban the first senator's right in round 1. 
//And in round 2, the third senator can just announce the victory since he is the only guy in the senate who can vote.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2_Senate
{
    public class Program
    {
        static void Main(string[] args)
        {
            string senate = "RDD";
            Solution solution = new Solution();
            Console.WriteLine(solution.solve_dota2_senate(senate));
            Console.ReadKey();
        }
    }
}
