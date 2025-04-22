/*Example 1:

Input
["Trie", "insert", "search", "search", "startsWith", "insert", "search"]
[[], ["apple"], ["apple"], ["app"], ["app"], ["app"], ["app"]]
Output
[null, null, true, false, true, null, true]

Explanation
Trie trie = new Trie();
trie.insert("apple");
trie.search("apple");   // return True
trie.search("app");     // return False
trie.startsWith("app"); // return True
trie.insert("app");
trie.search("app");     // return True*/

class TrieNode
{
    constructor()
    {
        this.children = new Map();
        this.isEnd = false;
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
        let node = this.root;
        for (let char of word)
        {
            if (!node.children.has(char))
            {
                node.children.set(char, new TrieNode());
            }
            node = node.children.get(char);
        }
        node.isEnd = true;
    }
    search(word)
    {
        let node = this.root;
    
        for (let char of word)
        {
            if (!node.children.has(char))
            {
                return false;
            }
            node = node.children.get(char);
        }
        return node.isEnd;
    }
    startsWith(prefix)
    {
        let node = this.root;

        for (let char of prefix)
        {
            if (!node.children.has(char))
            {
                return false;
            }
            node = node.children.get(char);
        }
        return true;
    }
}