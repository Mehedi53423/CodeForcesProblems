using System;
using System.Linq;

namespace HelpfulMaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = string.Concat(Console.ReadLine().Replace("+", "").OrderBy(x => x));
            string a = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1)
                {
                    a += s[i];
                }
                else
                {
                    a = a + s[i] + "+";
                }
            }

            Console.WriteLine(a);
        }
    }
}