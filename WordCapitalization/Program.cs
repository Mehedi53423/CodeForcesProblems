using System;

namespace WordCapitalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Console.WriteLine(s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length - 1));
        }
    }
}
