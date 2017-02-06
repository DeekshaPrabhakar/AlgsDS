using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Strings
{
    public class PalindromeString
    {
        public static void Run()
        {
            Console.WriteLine(isPalindrome("\"A man, a plan, a canal: Panama][:\"").ToString());//1
            Console.WriteLine(isPalindrome("race a car").ToString());//0
            Console.WriteLine(isPalindrome("1a2").ToString());//0
            Console.WriteLine(isPalindrome("a").ToString());//1 
        }
        private static int isPalindrome(string A)
        {
            int isPalindromeString = 1;

            char[] str = A.ToCharArray();
            int forwardIndex = 0;
            int backwardIndex = str.Length - 1;
            bool isMiddle = false;

            while (forwardIndex < str.Length && backwardIndex >= 0)
            {
                while (forwardIndex < str.Length && (str[forwardIndex].ToString().Trim() == "" || !Char.IsLetter(str[forwardIndex])))
                {
                    forwardIndex++;
                }
                while (backwardIndex >= 0 && (str[backwardIndex].ToString().Trim() == "" || !Char.IsLetter(str[backwardIndex])))
                {
                    backwardIndex--;
                }
                if (forwardIndex < str.Length && backwardIndex >= 0)
                {
                    if (!isMiddle && forwardIndex == backwardIndex && forwardIndex != 0)
                    {
                        isPalindromeString = 0;
                        return isPalindromeString;
                    }

                    if (str[forwardIndex].ToString().ToLower() != str[backwardIndex].ToString().ToLower())
                    {
                        isPalindromeString = 0;
                        return isPalindromeString;
                    }
                    else
                    {
                        isMiddle = true;
                    }
                }
                forwardIndex++;
                backwardIndex--;
            }
            return isPalindromeString;
        }

        /*
         * ***** Palindrome String *****
         * 

            Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

            Example:

            "A man, a plan, a canal: Panama" is a palindrome.

            "race a car" is not a palindrome.

            Return 0 / 1 ( 0 for false, 1 for true ) for this problem

         */
    }
}
