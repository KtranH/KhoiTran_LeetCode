using System;
using System.Collections.Generic;

namespace HappyNumber
{
    class Program
    {
        static void solve_happy_number(int n)
        {
            Dictionary<int, bool> hash_map = new Dictionary<int, bool>();
            while (n != 1 && !hash_map.ContainsKey(n))
            {
                hash_map[n] = true;
                int new_n = 0;
                while (n > 0)
                {
                    int digit = n % 10;
                    new_n += digit * digit;
                    n /= 10;
                }
                n = new_n;
            }
            return n == 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solve_happy_number(19));
            Console.ReadKey();
        }
    }
}