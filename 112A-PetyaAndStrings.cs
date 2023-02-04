using System;

namespace PetyaAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine().ToLower();
            string s2 = Console.ReadLine().ToLower();

            int i;

            for(i = 0; i < s1.Length; i++)
            {
                if (s1[i] > s2[i])
                {
                    Console.WriteLine("1");
                    break;
                }
                else if (s1[i] < s2[i])
                {
                    Console.WriteLine("-1");
                    break;
                }
            }

            if(i == s1.Length)
            {
                Console.WriteLine("0");
            }
        }
    }
}
