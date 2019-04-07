using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace lesson7
{
    public class Palindrom
    {
        public void IsPalindrome( string string1)
            {
                string rev;
                //string string1 = "Malayalam";
                char[] ch = string1.ToCharArray();

                Array.Reverse(ch);
                rev = new string(ch);

                bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);

                if (b == true) {
                    Console.WriteLine("" + string1 + " is a Palindrome!");
                } else {
                    Console.WriteLine(" " + string1 + " is not a Palindrome!");
                }
                Console.Read();
            }
    }
}
