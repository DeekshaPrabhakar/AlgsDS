using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Hashing
{
    public class PhoneBook
    {
        public static void Run()
        {
            int noOfEntries = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> phoneMap = new Dictionary<string, string>();

            for(int i=0; i< noOfEntries; i++)
            {
                string[] inpt = Console.ReadLine().Split(' ');
                if (!phoneMap.ContainsKey(inpt[0]))
                {
                    phoneMap.Add(inpt[0], inpt[1]);
                }
            }

            List<string> output = new List<string>();
            string line;
            while ((line = Console.ReadLine()) != null && line != "")
            {
                output.Add(line);
            }
           
            
            foreach(string name in output)
            {
                if(phoneMap.ContainsKey(name))
                {
                    Console.WriteLine(name + "=" + phoneMap[name]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
