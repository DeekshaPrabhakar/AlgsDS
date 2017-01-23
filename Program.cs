using AlgsDS.Arrays;
using AlgsDS.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(WordsBucket.reverseWords("   fwbpudnbrozzifml osdt  ulc jsx kxorifrhubk ouhsuhf  sswz qfho dqmy  sn myq igjgip iwfcqq"));
            //Console.WriteLine(WordsBucket.lengthOfLastWord("Hello world  ").ToString());  

            //Console.WriteLine(MissingOrRepeatedNumber.repeatedNumber(new List<int>(new int[]{ 3, 4, 1, 4, 1 })).ToString());

            //String input = \"{A:\\"B\\",C:{D:\\"E\\",F:{G:\\"H\\",I:\\"J\\"}}}\";
            //String input = \"[\\"foo\\", {\\"bar\\":[\\"baz\\",null,1.0,2]}]\";
            //String input = \"{\\"id\\":100,\\"firstName\\":\\"Jack\\",\\"lastName\\":\\"Jones\\",\\"age\\":12}\";
            //String input = "{\"attributes\":[{\"nm\":\"ACCOUNT\",\"lv\":[{\"v\":{\"Id\":null,\"State\":null},\"vt\":\"java.util.Map\",\"cn\":1}],\"vt\":\"java.util.Map\",\"status\":\"SUCCESS\",\"lmd\":13585},{\"nm\":\"PROFILE\",\"lv\":[{\"v\":{\"Party\":null,\"Ads\":null},\"vt\":\"java.util.Map\",\"cn\":2}],\"vt\":\"java.util.Map\",\"status\":\"SUCCESS\",\"lmd\":41962}]}";
            //DisplayJSON(PrettyPrint.prettyJSON(input));

            Console.WriteLine(StringSimulation.isPalindrome("\"A man, a plan, a canal: Panama][:\"").ToString());//1
            Console.WriteLine(StringSimulation.isPalindrome("race a car").ToString());//0
            Console.WriteLine(StringSimulation.isPalindrome("1a2").ToString());//0
            Console.WriteLine(StringSimulation.isPalindrome("a").ToString());//1


            Console.WriteLine(StringMath.addBinary("110", "11"));
            Console.WriteLine(StringMath.addBinary("100", "11"));
            Console.WriteLine(StringMath.addBinary("1010110111001101101000", "1000011011000000111100110"));

           DisplayList(ArrayMath.plusOne(new List<int>(new int[] { 0 })));
           DisplayList(ArrayMath.plusOne(new List<int>(new int[] { 0, 0, 0, 2, 5, 6, 8, 6, 1, 2, 4, 5 })));

            Console.ReadLine();
        }

        public static void DisplayJSON(List<String> list)
        {
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }

        public static void DisplayList(List<int> list)
        {
            Console.WriteLine("Elements:");
            foreach (var value in list)
            {
                Console.Write(value);
                Console.Write(' ');
            }
        }


    }
}
