using System;

namespace Bit__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int x = 0;

            while (n > 0)
            {
                string w = Console.ReadLine();

                if (w[0] == '+' || w[w.Length - 1] == '+')
                {
                    x++;
                }
                else
                {
                    x--;
                }
                n--;
            }

            Console.WriteLine(x);
        }
    }
}