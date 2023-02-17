using System;

namespace Watermelon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int w = Convert.ToInt32(Console.ReadLine());

            if (w % 2 == 0)
            {
                if (w == 2)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}