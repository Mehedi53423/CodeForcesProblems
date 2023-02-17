using System;

namespace Translation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            string a = "";

            for(int i = s.Length-1; i >=0; i--)
            {
                a += s[i];
            }

            if(t == a)
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
