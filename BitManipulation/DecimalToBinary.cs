using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.BitManipulation
{
    public class DecimalToBinary
    {
         public static void Run(){
             AlgsDSHelper.DisplayList(decimalToBin(125));
         }

        public static List<int> decimalToBin(int n)
        {
            List<int> list = new List<int>();
            while(n>0)
            {
                int rem = n%2;
                list.Add(rem);
                n = n/2;
            }
            list.Reverse();
            return list;
        }
    }
}
