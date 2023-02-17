using System;

namespace AntonAndDanik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();

            int a = 0, d = 0;

            for(int i = 0; i < n; i++)
            {
                if (s[i] == 'A')
                {
                    a++;
                }
                else
                {
                    d++;
                }
            }

            if(a > d)
            {
                Console.WriteLine("Anton");
            }
            else if(a == d)
            {
                Console.WriteLine("Friendship");
            }
            else
            {
                Console.WriteLine("Danik");
            }
        }
    }
}
