using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Kata
{
    public static class Kata_Class
    {

        public static void Main(string[] args)
        {
            
        }

        //enter a value and add all products of 3 /& 5 that make up that value 
        public static int MultipleOf3Or5(int value)
        {
            var sum = 0;
            for( int i=3; i<value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        //Write a function that takes in a string of one or more words,
        //and returns the same string, but with all five or more letter words reversed 
        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            var reversePhrase = "";
            int count = 0;
            foreach (var word in words)
            {
                if (count > 0)
                {
                    reversePhrase += " ";
                }
                if (word.Length >= 5)
                {
                    char[] wordArr = word.ToCharArray();
                    Array.Reverse(wordArr);
                    reversePhrase += new string(wordArr);
                    
                }
                else
                {  
                    reversePhrase += word;
                }
               
                count++;
                
            }
            return reversePhrase;
        }

        //Delete the nth occurence of a value from an array
        public static int[] DeleteNth(int[] arr, int x)
        {
            var occurences = new Dictionary<int, int>();
            var list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!occurences.ContainsKey(arr[i])) occurences.Add(arr[i], 1);
                else occurences[arr[i]]++;
                if (occurences[arr[i]] <= x) list.Add(arr[i]);
            }
            return list.ToArray();
        }

        //Convert RGB to a hexedecimal format
        public static string Rgb(int r, int g, int b)
        {
            r = Math.Max(Math.Min(255, r), 0);
            g = Math.Max(Math.Min(255, g), 0);
            b = Math.Max(Math.Min(255, b), 0);
            return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
        }

        public static bool IsPangram(string str)
        {
            str = str.ToLower();
            str= Regex.Replace(str, @"[^a-z]+", String.Empty);
            HashSet<char> lettersUsed = str.ToHashSet();
            List<char> lettersUsedList = lettersUsed.ToList();
            lettersUsedList.Sort();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            if (lettersUsedList.SequenceEqual(alpha))
            {
                return true;
            }
            return false;
        }

        public static string ExpandedForm(long num)
        {
            var charArray = num.ToString().ToCharArray();
            var expandedStr = "";
            for (var i = 0; i < charArray.Length; i++)
            {
                var x = charArray[i];
                
                if (!x.Equals('0'))
                {
                    expandedStr += x;
                    for (var j = 1; j < charArray.Length - i; j++)
                    {
                        expandedStr += "0";
                    }
                }
                // var remainingChar = charArray[i..];
                var remainingChar =charArray.ToList().GetRange(i, charArray.Length - i).ToArray();
                if (i < charArray.Length-1&&remainingChar[1]!='0')
                {
                    expandedStr += " + ";
                }
            }
            return expandedStr;
        }
    }
}
