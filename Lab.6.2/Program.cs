using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = s1.Replace(" ", "");
            string s3 = "";

            for (int i = s2.Length - 1; i >= 0; i--)
            {
                s3 += s2[i];
            }
            if (s2 == s3)
                Console.WriteLine("Палиндром!");
            else
                Console.WriteLine("Не палиндром!");

            Console.ReadKey();
        }
    }
}
