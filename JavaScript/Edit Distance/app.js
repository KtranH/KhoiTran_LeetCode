const word1 = "horse";
const word2 = "ros";

/*Example 1:

Input: word1 = "horse", word2 = "ros"
Output: 3
Explanation: 
horse -> rorse (replace 'h' with 'r')
rorse -> rose (remove 'r')
rose -> ros (remove 'e')
Example 2:

Input: word1 = "intention", word2 = "execution"
Output: 5
Explanation: 
intention -> inention (remove 't')
inention -> enention (replace 'i' with 'e')
enention -> exention (replace 'n' with 'x')
exention -> exection (replace 'n' with 'c')
exection -> execution (insert 'u')*/

function solve_edit_distance(word1, word2)
{
    let m = word1.length;
    let n = word2.length;
    let dp = Array.from({ length: m + 1 }, () => Array(n + 1).fill(0));
    for(let i = 0; i <= m; i++)
    {
        dp[i][0] = i;
    }
    for(let j = 0; j <= n; j++)
    {
        dp[0][j] = j;
    }
    for(let i = 1; i <= m; i++)
    {
        for(let j = 1; j <= n; j++)
        {
            if(word1[i - 1] === word2[j - 1])
            {
                dp[i][j] = dp[i - 1][j - 1];
            }
            else
            {
                dp[i][j] = Math.min(dp[i - 1][j], dp[i][j - 1], dp[i - 1][j - 1]) + 1;
            }
        }
    }
    return dp[m][n];
}

console.log(solve_edit_distance(word1, word2));