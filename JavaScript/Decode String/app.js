/*Example 1:

Input: s = "3[a]2[bc]"
Output: "aaabcbc"
Example 2:

Input: s = "3[a2[c]]"
Output: "accaccacc"
Example 3:

Input: s = "2[abc]3[cd]ef"
Output: "abcabccdcdcdef"*/

const s = "3[a]2[bc]";

function solve_decode_string(s)
{
    let stack = [];
    let current_num = 0;
    let current_str = "";

    for (let i = 0; i < s.length; i++)
    {
        if(s[i] >= '0' && s[i] <= '9')
        {
            current_num = current_num * 10 + (s[i] - '0');
        }
        else if(s[i] === '[')
        {
            stack.push([current_num, current_str]);
            current_num = 0;
            current_str = "";
        }
        else if(s[i] === ']')
        {
            let [prev_num, prev_str] = stack.pop();
            current_str = prev_str + current_str.repeat(prev_num);
        }
        else
        {
            current_str += s[i];
        }
    }
    return current_str;
}

console.log(solve_decode_string(s)); // Output: "aaabcbc"