using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Strings
{
    public class PrettyJSON
    {
        public static List<string> prettyJSON(string A)
        {
            List<string> json = new List<string>();

            char[] str = A.ToCharArray();
            bool isOpen = false;
            bool isClose = false;
            StringBuilder indentation = new StringBuilder();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString().Trim().Length > 0)
                {
                    isOpen = (str[i] == '{' || str[i] == '[');
                    isClose = (str[i] == '}' || str[i] == ']');

                    if (isOpen || isClose)
                    {
                        if (isOpen)
                        {
                            json.Add(indentation.ToString() + str[i].ToString());
                            indentation.Append("\t");
                            sb = new StringBuilder();
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(sb.ToString()))
                            {// for cases where there is more than one attribute
                                json.Add(indentation.ToString() + sb.ToString());
                                sb = new StringBuilder();
                            }
                            if (indentation.Length > 0)
                            {
                                indentation.Remove(0, 1);
                            }
                            if (i + 1 < str.Length && str[i + 1] == ',')
                            {
                                json.Add(indentation.ToString() + str[i].ToString() + str[i + 1].ToString());
                            }
                            else
                            {
                                json.Add(indentation.ToString() + str[i].ToString());
                            }
                        }
                    }
                    else
                    {
                        if (str[i] == ',')
                        {
                            if (i - 1 >= 0 && str[i - 1] == '}' || str[i - 1] == ']')
                            {
                                //comma has already been appended when the brackets were closed
                            }
                            else
                            {
                                json.Add(indentation.ToString() + sb.ToString() + str[i].ToString());
                                sb = new StringBuilder();
                            }
                        }
                        else if (str[i] == ':' && i + 1 < str.Length && (str[i + 1] == '{' || str[i + 1] == '['))
                        {
                            json.Add(indentation.ToString() + sb.ToString() + str[i].ToString());
                            sb = new StringBuilder();
                        }
                        else
                        {
                            sb.Append(str[i]);
                        }
                    }
                }
            }

            return json;
        }

        /*
         * ***** Pretty Json *****
         *

                Pretty print a json object using proper indentation.

                    Every inner brace should increase one indentation to the following lines.
                    Every close brace should decrease one indentation to the same line and the following lines.
                    The indents can be increased with an additional ‘\t’

                Example 1:

                Input : {A:"B",C:{D:"E",F:{G:"H",I:"J"}}}
                Output : 
                { 
                    A:"B",
                    C: 
                    { 
                        D:"E",
                        F: 
                        { 
                            G:"H",
                            I:"J"
                        } 
                    }     
                }

                Example 2:

                Input : ["foo", {"bar":["baz",null,1.0,2]}]
                Output : 
                [
                    "foo", 
                    {
                        "bar":
                        [
                            "baz", 
                            null, 
                            1.0, 
                            2
                        ]
                    }
                ]

                [] and {} are only acceptable braces in this case.

                Assume for this problem that space characters can be done away with.

                Your solution should return a list of strings, where each entry corresponds to a single line. The strings should not have “\n” character in them.

         * 
         */
    }
}
