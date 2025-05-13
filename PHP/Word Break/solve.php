<?php

$s = "leetcode";
$wordDict = ["leet", "code"];   

/*Example 1:

Input: s = "leetcode", wordDict = ["leet","code"]
Output: true
Explanation: Return true because "leetcode" can be segmented as "leet code".
Example 2:

Input: s = "applepenapple", wordDict = ["apple","pen"]
Output: true
Explanation: Return true because "applepenapple" can be segmented as "apple pen apple".
Note that you are allowed to reuse a dictionary word.
Example 3:

Input: s = "catsandog", wordDict = ["cats","dog","sand","and","cat"]
Output: false*/

function solveWordBreak($s, $wordDict)
{
    $n = strlen($s);
    $wordSet = array_flip($wordDict);
    $dp = array_fill(0, $n + 1, false);
    $dp[0] = true;
    for ($i = 1; $i <= $n; $i++)
    {
        for ($j = 0; $j < $i; $j++)
        {
            $subString = substr($s, $j, $i - $j);
            if ($dp[$j] && isset($wordSet[$subString]))
            {
                $dp[$i] = true;
                break;
            }
        }
    }
    return $dp[$n];
}

var_dump(solveWordBreak($s, $wordDict));
