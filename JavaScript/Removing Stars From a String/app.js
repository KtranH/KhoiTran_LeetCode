/*Example 1:

Input: s = "leet**cod*e"
Output: "lecoe"
Explanation: Performing the removals from left to right:
- The closest character to the 1st star is 't' in "leet**cod*e". s becomes "lee*cod*e".
- The closest character to the 2nd star is 'e' in "lee*cod*e". s becomes "lecod*e".
- The closest character to the 3rd star is 'd' in "lecod*e". s becomes "lecoe".
There are no more stars, so we return "lecoe".
Example 2:

Input: s = "erase*****"
Output: ""
Explanation: The entire string is removed, so we return an empty string.*/

const s = "leet**cod*e";

function solve_removing_stars_from_a_string(s)
{
    let stack = [];
    for(let i = 0; i < s.length; i++)
    {
        if(s[i] === "*")
        {
            stack.pop();
        }
        else
        {
            stack.push(s[i]);
        }
    }

    return stack.join("");
}

console.log(solve_removing_stars_from_a_string(s));