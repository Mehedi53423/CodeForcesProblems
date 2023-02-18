using System;

namespace QueueAtTheSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] s = Console.ReadLine().Split(' ');
            string a = Console.ReadLine();
            string p = "";

            for (int i = 0; i < Convert.ToInt16(s[1]); i++)
            {
                for (int j = 0; j < Convert.ToInt16(s[0]); j++)
                {
                    if(j == Convert.ToInt16(s[0]) - 1)
                    {
                        p += a[j];
                    }
                    else if (a[j] == 'B' && a[j+1] == 'G')
                    {
                        p += "GB";
                        j++;
                    }
                    else
                    {
                        p += a[j];
                    }
                }
                a = p;
                p = "";
            }
            Console.WriteLine(a);
        }
    }
}
