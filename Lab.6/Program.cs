using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            int max = 0;
            string s1 = stringArray[0];

            foreach (string s in stringArray)
            {
                if ( s.Length >= max)   
                { 
                    max = s.Length;
                    s1 = s;
                    
                }
                else
                {
                    max = max;
                }
            }

            Console.Write(s1);
            Console.ReadKey();
        }
    }
}
