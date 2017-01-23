using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Strings
{
    public class PrettyPrint
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
    }
}
