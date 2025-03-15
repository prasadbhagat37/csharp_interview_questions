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
            //reverseWordOrder("Welcome to Csharp corner");
            //reverseWords("Welcome to Csharp corner");
            //removeduplicate("Welcome to Csharp corner");
            Console.Read();
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

        static void reverseWordOrder(string str)
        {
            int i = 0;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (int j = 0; j <= End; j++)
            {
                reverseSentence.Append(str[j]);
            }
            Console.WriteLine(reverseSentence.ToString());
        }

        static void reverseWords(string str)
        {
            char[] inputArray = str.ToCharArray();
            int start = 0;

            // Loop through the characters in the input
            for (int i = 0; i <= inputArray.Length; i++)
            {
                // When we find a space or reach the end of the string, reverse the word
                if (i == inputArray.Length || inputArray[i] == ' ')
                {
                    int end = i - 1;
                    while (start < end)
                    {
                        char temp = inputArray[start];
                        inputArray[start] = inputArray[end];
                        inputArray[end] = temp;
                        start++;
                        end--;
                    }
                    start = i + 1; // Move to the next word
                }
            }

            Console.WriteLine(new string(inputArray));
        }
        
        static void removeduplicate(string str)
        {
            string newString = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!newString.Contains(str[i]))
                {
                    newString += str[i];
                }
            }

            Console.WriteLine(newString);
        }
    }
}
