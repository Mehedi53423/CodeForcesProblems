using System;

namespace StringTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower().Replace('a', ' ').Replace('o', ' ').Replace('y', ' ').Replace('e', ' ').Replace('u', ' ').Replace('i', ' ').Replace(" ", "");
            string a = "";

            for (int i = 0; i < s.Length; i++)
            {
                a = a + "." + s[i];
            }

            Console.WriteLine(a);
        }
    }
}