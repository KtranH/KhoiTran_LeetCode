using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Implement_Trie__Prefix_Tree_.Solution;

//Example 1:

//Input
//["Trie", "insert", "search", "search", "startsWith", "insert", "search"]
//[[], ["apple"], ["apple"], ["app"], ["app"], ["app"], ["app"]]
//Output
//[null, null, true, false, true, null, true]

//Explanation
//Trie trie = new Trie();
//trie.insert("apple");
//trie.search("apple");   // return True
//trie.search("app");     // return False
//trie.startsWith("app"); // return True
//trie.insert("app");
//trie.search("app");     // return True

namespace Implement_Trie__Prefix_Tree_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Solution.TrieNode node = new Solution.TrieNode();
            Solution.Trie trie = new Solution.Trie();
            trie.Insert("apple");
            Console.WriteLine(trie.Search("apple"));
            Console.WriteLine(trie.Search("app"));
            Console.WriteLine(trie.StartsWith("app"));
            trie.Insert("app");
            Console.WriteLine(trie.Search("app"));
            Console.WriteLine(trie.StartsWith("app"));
        }
    }
}
