/*Example 1:

Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"
Example 2:

Input: str1 = "ABABAB", str2 = "ABAB"
Output: "AB"
Example 3:

Input: str1 = "LEET", str2 = "CODE"
Output: ""*/

const str1 = "ABCABC";
const str2 = "ABC";

function find_gcd(a, b)
{
    if (b == 0)
        return a;
    return find_gcd(b, a % b);
}
function check_string(s1, s2)
{
    if(s1 + s2 !== s2 + s1)
        return false;
    return true;
}
function slove_greatest_common_divisor_of_strings(str1, str2)
{
    if (!check_string(str1, str2))
        return "";
    const gcd = find_gcd(str1.length, str2.length);
    return str1.slice(0, gcd);
}

console.log(slove_greatest_common_divisor_of_strings(str1, str2));