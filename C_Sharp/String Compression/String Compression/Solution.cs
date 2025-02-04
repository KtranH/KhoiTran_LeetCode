using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace String_Compression
{
    public class Solution
    {
        public int solve_string_compression(char[] chars)
        {
            int write_index = 0;
            int read_index = 0;
            int length_chars = chars.Count();

            while(read_index < length_chars)
            {
                char current_char = chars[read_index];
                int count = 0;

                while(read_index < length_chars && chars[read_index] == current_char)
                {
                    read_index++;
                    count++;
                }
                chars[write_index] = current_char;
                write_index++;

                if(count > 1)
                {
                    foreach(char c in count.ToString())
                    {
                        chars[write_index] = c;
                        write_index++;
                    }    
                } 
            }
            for(int i = write_index; i < length_chars; i++)
            {
                chars[i] = '\0';
            }    
            return write_index;
        }
    }
}
