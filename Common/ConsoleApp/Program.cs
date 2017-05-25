using Common;
using Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestClass.show();

            
            //#region 字符空值判断
            //string s = "";
            //Console.WriteLine(string.IsNullOrEmpty(s));
            //Console.WriteLine(s.IsNullOrEmpty());

            //#endregion

            string num = "ldp615";
            
            string pattern = @"[a-zA-Z]+";

            //var res = Regex.IsMatch(num, pattern);
            var res = num.IsMatch(pattern);

            Console.WriteLine(res);

            Console.WriteLine(num.Match(pattern));


            Console.ReadKey();
        }
    }
}
