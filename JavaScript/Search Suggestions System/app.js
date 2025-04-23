const products = ["mobile", "mouse", "moneypot", "monitor", "mousepad"];
const searchWord = "mouse";

/*Example 1:

Input: products = ["mobile","mouse","moneypot","monitor","mousepad"], searchWord = "mouse"
Output: [["mobile","moneypot","monitor"],["mobile","moneypot","monitor"],["mouse","mousepad"],["mouse","mousepad"],["mouse","mousepad"]]
Explanation: products sorted lexicographically = ["mobile","moneypot","monitor","mouse","mousepad"].
After typing m and mo all products match and we show user ["mobile","moneypot","monitor"].
After typing mou, mous and mouse the system suggests ["mouse","mousepad"].
Example 2:

Input: products = ["havana"], searchWord = "havana"
Output: [["havana"],["havana"],["havana"],["havana"],["havana"],["havana"]]
Explanation: The only word "havana" will be always suggested while typing the search word.*/

class TrieNode
{
    constructor()
    {
        this.children = new Map();
        this.words = [];
    }
}
class Trie
{
    constructor()
    {
        this.root = new TrieNode();
    }
    insert(word)
    {
        let current = this.root;
        for (let char of word)
        {
            if (!current.children.has(char))
            {
                current.children.set(char, new TrieNode());
            }
            current = current.children.get(char);
            if (current.words.length < 3 && !current.words.includes(word))
            {
                current.words.push(word);
            }
        }
    }
    searchPrefix(prefix)
    {
        let current = this.root;
        for (let char of prefix)
        {
            if (!current.children.has(char))
            {
                return [];
            }
            current = current.children.get(char);
        }
        return current.words;
    }
    solve_search_suggestions_system()
    {
        products.sort();
        for (const product of products)
        {
            trie.insert(product);
        }
        const results = [];
        let prefix = "";
        for (const char of searchWord)
        {
            prefix += char;
            results.push(trie.searchPrefix(prefix));
        }
        return results;
    }
}