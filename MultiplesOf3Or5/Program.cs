using System;
using System.Collections.Generic;

namespace Kata
{
    public static class Kata_Class
    {

        public static void Main(string[] args)
        { 
         Console.WriteLine(MultipleOf3Or5(200));
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

    }
}
