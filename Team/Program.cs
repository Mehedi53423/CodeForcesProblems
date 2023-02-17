using System;

namespace Team
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0;

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if((Convert.ToInt16(s[0]) + Convert.ToInt16(s[1]) + Convert.ToInt16(s[2])) >= 2)
                {
                    a++;
                }
            }
            Console.WriteLine(a);
        }
    }
}
