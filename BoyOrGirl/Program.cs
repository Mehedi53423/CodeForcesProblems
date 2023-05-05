using System;
using System.Linq;

namespace BoyOrGirl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string a = new string(s.Distinct().ToArray());

            if (a.Length % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
        }
    }
}