using System;

namespace DominoPiling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] s = Console.ReadLine().Split(' ');

            Console.WriteLine((Convert.ToInt32(s[0]) * Convert.ToInt32(s[1])) / 2);
        }
    }
}
