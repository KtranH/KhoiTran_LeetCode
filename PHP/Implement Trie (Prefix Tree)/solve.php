<?php

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
    public $children;
    public $isEnd;
    public function __construct()
    {
        $this->children = [];
        $this->isEnd = false;
    }
}
class Trie
{
    public $root;
    public function __construct()
    {
        $this->root = new TrieNode();
    }
    public function insert($word)
    {
        $node = $this->root;
        foreach (str_split($word) as $char)
        {
            if (!isset($node->children[$char]))
            {
                $node->children[$char] = new TrieNode();
            }
            $node = $node->children[$char];
        }
        $node->isEnd = true;
    }
    public function search($word)
    {
        $node = $this->_traverse($word);
        return $node !== null and $node->isEnd;
    }
    public function startsWith($prefix)
    {
        $node = $this->_traverse($prefix);
        return $node !== null;
    }
    private function _traverse($word)
    {
        $node = $this->root;
        foreach (str_split($word) as $char)
        {
            if (!isset($node->children[$char]))
            {
                return null;
            }
            $node = $node->children[$char];
        }
        return $node;
    }
}