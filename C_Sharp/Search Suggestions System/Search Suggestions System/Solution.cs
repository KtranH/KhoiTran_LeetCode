using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Suggestions_System
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; set; }
        public List<string> Words { get; set; }

        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            Words = new List<string>();
        }
    }   
    internal class Solution
    {
        public TrieNode Root { get; set; }
        public Solution()
        {
            Root = new TrieNode();
        }
        public void Insert(string word)
        {
            TrieNode current = Root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!current.Children.ContainsKey(word[i]))
                {
                    current.Children.Add(word[i], new TrieNode());
                }
                current = current.Children[word[i]];
                if (current.Words.Count < 3 && !current.Words.Contains(word))
                {
                    current.Words.Add(word);
                }
            }
        }
        public List<string> Search(string word)
        {
            TrieNode current = Root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!current.Children.ContainsKey(word[i]))
                {
                    return new List<string>();
                }
                current = current.Children[word[i]];
            }
            return current.Words;
        }
        public IList<IList<string>> solve_search_suggestions_system(string[] products, string searchWord)
        {
            products = products.OrderBy(x => x).ToArray();
            foreach (string product in products)
            {
                Insert(product);
            }
            IList<IList<string>> result = new List<IList<string>>();
            string prefix = "";
            foreach (char ch in searchWord)
            {
                prefix += ch;
                result.Add(Search(prefix));
            }
            return result;
        }
    }
}
