using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //getletterCount("AAbbccDdacC");
            //reverseString("AAbbccDdacC");
            //checkPalindrome("Palindrome");
            //checkPalindrome("madam");
        }

        static void getletterCount(string msg)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char c in msg)
            {
                char newC = char.ToUpper(c);
                if (letterCount.ContainsKey(newC))
                {
                    letterCount[newC]++;
                }
                else
                {
                    letterCount[newC] = 1;
                }
            }

            foreach (var entry in letterCount)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }
            Console.Read();
        }

        static void getReverseString(string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }

            string reversedString = new string(charArray);
            Console.WriteLine(reversedString);
            Console.Read();
        }

        static void checkPalindrome(string str)
        {
            bool IsPalindrome = false;

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] == str[j])
                {
                    IsPalindrome = true;
                }
                else
                {
                    IsPalindrome = false;
                }
            }
            if (IsPalindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
