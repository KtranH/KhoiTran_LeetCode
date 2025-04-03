using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Combinations_of_a_Phone_Number
{
    internal class Solution
    {
        public void backtracking(string digits, string path, IList<string> result, int index, int lenDigits, Dictionary<char, string> phone) {
            if(index == lenDigits) {
                result.Add(path);
                return;
            }
            char current_digit = digits[index];
            foreach (char i in phone[current_digit])
            {
                backtracking(digits, path + i, result, index + 1, lenDigits, phone);
            }
        }
        public IList<string> solve_letter_combinations(string digits)
        {
            if(digits.Length == 0) return new List<string>();
            Dictionary<char, string> phone = new Dictionary<char, string>();
            phone.Add('2', "abc");
            phone.Add('3', "def");
            phone.Add('4', "ghi");
            phone.Add('5', "jkl");
            phone.Add('6', "mno");
            phone.Add('7', "pqrs");
            phone.Add('8', "tuv");
            phone.Add('9', "wxyz");
            IList<string> result = new List<string>();
            int lenDigits = digits.Length;
            backtracking(digits, "", result, 0, lenDigits, phone);
            return result;
        }
    }
}
