﻿using AlgsDS.Arrays;
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
            Console.WriteLine("AddOneToNumber: [0]");
            DisplayList(AddOneToNumber.plusOne(new List<int>(new int[] { 0 })));
            Console.WriteLine("AddOneToNumber: [0, 0, 0, 2, 5, 6, 8, 6, 1, 2, 4, 5]");
            DisplayList(AddOneToNumber.plusOne(new List<int>(new int[] { 0, 0, 0, 2, 5, 6, 8, 6, 1, 2, 4, 5 })));

            Console.WriteLine();

            List<int> dsubList = new List<int>(new int[] { 1, 2, 3 });
            List<List<int>> dList = new List<List<int>>(dsubList.Count);
            dList.Add(dsubList);
            dsubList = new List<int>(new int[] {4,5,6 });
            dList.Add(dsubList);
            dsubList = new List<int>(new int[] { 7,8,9 });
            dList.Add(dsubList);

            Console.WriteLine("AntiDiagonals for input: ");
            Display(dList);
            Console.WriteLine();
            Display(AntiDiagonals.diagonal(dList));

            Console.WriteLine();
            
            Console.WriteLine("FindDuplicateInArray: [3,4,1,4,1]");
            Console.WriteLine(FindDuplicateInArray.repeatedNumber(new List<int>(new int[] {3,4,1,4,1 })));

            Console.WriteLine();

            Console.WriteLine("PascalTriangleRows: for 5 rows");
            Display(PascalTriangleRows.generate(5));

            Console.WriteLine();
           
            Console.WriteLine("SetMatrixZeros: for");
            List<int> msubList = new List<int>(new int[] { 1, 0, 1 });
            List<List<int>> mList = new List<List<int>>(msubList.Count);
            mList.Add(msubList);
            msubList = new List<int>(new int[] { 1, 1, 1 });
            mList.Add(msubList);
            msubList = new List<int>(new int[] { 1, 1, 1 });
            mList.Add(msubList);
            Display(mList);
            Console.WriteLine();
            Display(SetMatrixZeros.setMatrixZeros(mList));

            Console.WriteLine();
            
            Console.WriteLine("AddBinaryStrings: " + "110, " + "11");
            Console.WriteLine(AddBinaryStrings.addBinary("110", "11"));

            Console.WriteLine("AddBinaryStrings: " + "100, " + "11" );
            Console.WriteLine(AddBinaryStrings.addBinary("100", "11"));

            Console.WriteLine("AddBinaryStrings: " + "1010110111001101101000, " + "1000011011000000111100110");
            Console.WriteLine(AddBinaryStrings.addBinary("1010110111001101101000", "1000011011000000111100110"));

            Console.WriteLine();
            
            Console.WriteLine("LengthOfLastWord: Hello world  ");
            Console.WriteLine(LengthOfLastWord.lengthOfLastWord("Hello world  "));

            Console.WriteLine();
            
            Console.WriteLine("ReverseTheString:    fwbpudnbrozzifml osdt  ulc jsx kxorifrhubk ouhsuhf  sswz qfho dqmy  sn myq igjgip iwfcqq");
            Console.WriteLine(ReverseTheString.reverseWords("   fwbpudnbrozzifml osdt  ulc jsx kxorifrhubk ouhsuhf  sswz qfho dqmy  sn myq igjgip iwfcqq"));

            Console.WriteLine();
           
            String input = "{A:\"B\",C:{D:\"E\",F:{G:\"H\",I:\"J\"}}}";
            Console.WriteLine("PrettyJSON for " + input);
            DisplayJSON(PrettyJSON.prettyJSON(input));

            input = "[\"foo\", {\"bar\":[\"baz\",null,1.0,2]}]";
            Console.WriteLine("PrettyJSON for " + input);
            DisplayJSON(PrettyJSON.prettyJSON(input));

            input = "{\"id\":100,\"firstName\":\"Jack\",\"lastName\":\"Jones\",\"age\":12}";
            Console.WriteLine("PrettyJSON for " + input);
            DisplayJSON(PrettyJSON.prettyJSON(input));

            input = "{\"attributes\":[{\"nm\":\"ACCOUNT\",\"lv\":[{\"v\":{\"Id\":null,\"State\":null},\"vt\":\"java.util.Map\",\"cn\":1}],\"vt\":\"java.util.Map\",\"status\":\"SUCCESS\",\"lmd\":13585},{\"nm\":\"PROFILE\",\"lv\":[{\"v\":{\"Party\":null,\"Ads\":null},\"vt\":\"java.util.Map\",\"cn\":2}],\"vt\":\"java.util.Map\",\"status\":\"SUCCESS\",\"lmd\":41962}]}";
            Console.WriteLine("PrettyJSON for " + input);
            DisplayJSON(PrettyJSON.prettyJSON(input));

            Console.WriteLine();

            Console.WriteLine(PalindromeString.isPalindrome("\"A man, a plan, a canal: Panama][:\"").ToString());//1
            Console.WriteLine(PalindromeString.isPalindrome("race a car").ToString());//0
            Console.WriteLine(PalindromeString.isPalindrome("1a2").ToString());//0
            Console.WriteLine(PalindromeString.isPalindrome("a").ToString());//1

            Console.ReadLine();
        }

        public static void DisplayJSON(List<String> list)
        {
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }

        public static void Display(List<List<int>> list)
        {
            foreach (var sublist in list)
            {
                foreach (var value in sublist)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void DisplayList(List<int> list)
        {
            foreach (var value in list)
            {
                Console.Write(value);
                Console.Write(' ');
            }
                Console.WriteLine();
        }


    }
}
