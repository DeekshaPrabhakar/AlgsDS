using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Strings
{
    public class ReverseTheString
    {
        public static String reverseWords(String a)
        {
            String[] words = a.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i].Trim() != "")
                {
                    if (i == 0)
                    {
                        sb.Append(words[i]);
                    }
                    else
                    {
                        sb.Append(words[i] + " ");
                    }
                }
            }

            if (sb.Length > 1)
            {
                if (sb[sb.Length - 1].ToString().Trim().Length == 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
            }

            return sb.ToString();
        }

        /*
        ***Reverse the String***
    

        Given an input string, reverse the string word by word.

        Example:

        Given s = "the sky is blue",

        return "blue is sky the".

            "A sequence of non-space characters constitutes a word.
            Your reversed string should not contain leading or trailing spaces, even if it is present in the input string.
            If there are multiple spaces between words, reduce them to a single space in the reversed string."

     */
    }
}
