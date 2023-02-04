using System;

namespace BeautifulMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5,5];
            int v = 0;
            string s = "";

            for(int i = 0; i < 5; i++)
            {
                s +=Console.ReadLine();
            }

            s = s.Replace(" ", "");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = int.Parse(s[v].ToString());
                    v++;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a[i, j] == 1)
                    {
                        Console.WriteLine(Math.Abs(2 - i) + Math.Abs(2 - j));
                    }
                }
            }
        }
    }
}
