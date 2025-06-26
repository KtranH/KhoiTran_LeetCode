using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example 1:

//Input: ransomNote = "a", magazine = "b"
//Output: false
//Example 2:

//Input: ransomNote = "aa", magazine = "ab"
//Output: false
//Example 3:

//Input: ransomNote = "aa", magazine = "aab"
//Output: true

namespace Ransom_Note
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution(); 
            Console.WriteLine(solution.CanConstruct("a", "b"));
            Console.ReadLine();
        }
    }
}
