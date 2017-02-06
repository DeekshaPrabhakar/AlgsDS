using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Strings
{
    public class LengthOfLastWord
    {
        public static void Run()
        {
            Console.WriteLine("LengthOfLastWord: Hello world  ");
            Console.WriteLine(lengthOfLastWord("Hello world  "));
            Console.WriteLine();
        }
        private static int lengthOfLastWord(String a)
        {
            int count = 0;
            bool lastWordStarted = false;

            int i = a.Length - 1;
            while (i >= 0)
            {
                if (a[i].ToString() != " ")
                {
                    count++;
                    if (!lastWordStarted)
                    {
                        lastWordStarted = true;
                    }
                }
                if (a[i].ToString() == " " && lastWordStarted)
                {
                    break;
                }
                i--;
            }


            return count;
        }

    }

    /*
       ****Length of Last Word*****
     

       Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.

       If the last word does not exist, return 0.

       Note: A word is defined as a character sequence consists of non-space characters only.

       Example:

       Given s = "Hello World",

       return 5 as length("World") = 5.

       Please make sure you try to solve this problem without using library functions. Make sure you only traverse the string once.
     
    */
}
