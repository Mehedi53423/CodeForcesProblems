using System;

namespace StonesOnTheTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int a = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    a++;
                }
            }

            Console.WriteLine(a);
        }
    }
}