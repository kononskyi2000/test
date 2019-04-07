using System;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    public class Program
    {

        static void Main (string[] args)
        {
            string string1 = "oppo";
            Palindrom palindrom = new Palindrom();
            palindrom.IsPalindrome(string1);
        }
        
    }
}
