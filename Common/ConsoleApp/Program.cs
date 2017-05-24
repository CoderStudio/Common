using Common;
using Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass.show();

            string s = "";
            Console.WriteLine(string.IsNullOrEmpty(s));
            Console.WriteLine(s.IsNullOrEmpty());

            Console.ReadKey();
        }
    }
}
