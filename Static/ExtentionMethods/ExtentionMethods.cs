using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionMethods
{
    internal static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 == 0)
                return false;
            else
                return true;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false; ;
        }
        public static bool IsContainsDigit(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str)
                {
                    if (char.IsDigit(item))
                        return true;
                }
            }
            return false;
        }
        public static string ToCapitalize(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                str = str.Replace(str[0], char.ToUpper(str[0]));
                return str;
            }
            return null;
        }
        public static int[] GetValueIndexes(this string str, char chr)
        {
            int[] indexes = new int[0];
            if (!string.IsNullOrWhiteSpace(str))
            {
                while (str.Contains(chr))
                {
                    Array.Resize(ref indexes, indexes.Length + 1);
                    indexes[indexes.Length - 1] = str.LastIndexOf(chr);
                    str = str.Substring(0, str.LastIndexOf(chr));
                }
                Array.Reverse(indexes);
            }
            foreach (var item in indexes)
            {
                Console.WriteLine(item);
            }
            return indexes;
        }
    }
}
