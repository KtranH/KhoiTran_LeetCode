<?php

$products = ["mobile", "mouse", "moneypot", "monitor", "mousepad"];
$searchWord = "mouse";

/*Example 1:

Input: products = ["mobile","mouse","moneypot","monitor","mousepad"], searchWord = "mouse"
Output: [["mobile","moneypot","monitor"],["mobile","moneypot","monitor"],["mouse","mousepad"],["mouse","mousepad"],["mouse","mousepad"]]
Explanation: products sorted lexicographically = ["mobile","moneypot","monitor","mouse","mousepad"].
After typing m and mo all products match and we show user ["mobile","moneypot","monitor"].
After typing mou, mous and mouse the system suggests ["mouse","mousepad"].
Example 2:
Input: products = ["havana"], searchWord = "havana"
Output: [["havana"],["havana"],["havana"],["havana"],["havana"],["havana"]]
Explanation: The only word "havana" will be always suggested while typing the search word.
*/

class TrieNode
{
    public $children = [];
    public $words = [];

    public function __construct()
    {
        $this->children = [];
        $this->words = [];
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
        for ($i = 0; $i < strlen($word); $i++)
        {
            $char = $word[$i];
            if (!isset($node->children[$char]))
            {
                $node->children[$char] = new TrieNode();
            }
            $node = $node->children[$char];
            if (count($node->words) < 3 && !in_array($word, $node->words))
            {
                $node->words[] = $word;
            }
        }
    }
    public function searchPrefix($prefix)
    {
        $node = $this->root;
        for ($i = 0; $i < strlen($prefix); $i++)
        {
            $char = $prefix[$i];
            if (!isset($node->children[$char]))
            {
                return [];
            }
            $node = $node->children[$char];
        }
        return $node->words;
    }
    public function solve_search_suggestions_system($products, $searchWord)
    {
        sort($products);
        foreach ($products as $product)
        {
            $this->insert($product);
        }
        $results = [];
        $prefix = "";
        foreach (str_split($searchWord) as $char)
        {
            $prefix .= $char;
            $results[] = $this->searchPrefix($prefix);
        }
        return $results;
    }
}
