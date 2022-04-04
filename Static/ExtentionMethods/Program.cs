using System;

namespace ExtentionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4737;
            Console.WriteLine(num.IsOdd());
            Console.WriteLine(num.IsEven());
            string str = "salamlasmaq";
            Console.WriteLine(str.IsContainsDigit());
            Console.WriteLine(str.ToCapitalize());
            Console.WriteLine(str.GetValueIndexes('l'));
        }
    }
}
