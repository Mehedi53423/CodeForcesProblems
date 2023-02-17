using System;

namespace NextRound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] s = Console.ReadLine().Split(' ');
            string [] a = Console.ReadLine().Split(' ');
            int p = 0;

            for (int i = 0; i < Convert.ToInt32(s[0]); i++)
            {
                if (Convert.ToInt32(a[i]) >= Convert.ToInt32(a[Convert.ToInt32(s[1])-1]) && Convert.ToInt32(a[i]) > 0)
                {
                    p++;
                }
            }
            Console.WriteLine(p);
        }
    }
}
