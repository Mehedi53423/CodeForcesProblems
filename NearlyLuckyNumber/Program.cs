using System;

namespace NearlyLuckyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = 0;

            for(int i = 0; i< s.Length; i++)
            {
                if (s[i] == '4' || s[i] == '7')
                {
                    a++;
                }
            }

            if(a == 4 || a == 7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
