using System;

namespace WayTooLongWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());

            while(n > 0)
            {
                string w = Console.ReadLine();

                if (w.Length > 10)
                {
                    var c = w.Length;
                    Console.WriteLine("" + w[0] + (c - 2) + w[c - 1]);
                }
                else
                {
                    Console.WriteLine(w);
                }
                n--;
            }
        }
    }
}
