using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeProj
{
    class Program
    {
        public static bool truePalindrome(string s)
        {
            int min = 0;
            int max = s.Length - 1;
            while (true)
            {
                if (min > max) 
                    return true;

                if (char.ToLower(s[min++]) != char.ToLower(s[max]))
                    return false;
            }
        static void Main(string[] args)
        {
                string[] palindromes =
                 {
                    "racecar" , "1221" , "Racecar"
                };
          
                foreach (string value in truePalindrome)
                {
                    Console.WriteLine("{0} = {1}", value, truePalindrome(value));
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey(true);
            }
        }

    }
}
}
