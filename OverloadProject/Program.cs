using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadProject
{
    internal class Program
    {
        public void Test()
        {
            Console.WriteLine("1st Method");
        }

        public void Test(int i)
        {
            Console.WriteLine($"2nd Method {i}");
        }

        public void Test(string s)
        {
            Console.WriteLine($"3rd Method {s}");
        }

        public void Test(int i, string s)
        {
            Console.WriteLine($"4th Method {s}");
        }

        public void Test(string s, int i)
        {
            Console.WriteLine($"5th Method {s}");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            Console.ReadLine();
        }
    }
}
