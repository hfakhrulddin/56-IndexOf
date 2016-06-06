using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexof_Key
{
    class Program
    {
        static void Main(string[] args)
        {
                Print("collect");
                Console.ReadLine();
        }

        public static void Print(string s)
        {

            foreach (char c in s)
            {
                if (s.IndexOf(c) == 2)
                {
                    Console.WriteLine("*");
                }
                else {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
