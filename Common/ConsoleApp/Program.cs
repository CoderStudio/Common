﻿using Common;
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
            //TestClass.show();
            string str = "aaaabbbbccccddddeeeefff";
            var show = StringProcess.BankAccountWithSpace(str);
            Console.WriteLine(show);
            Console.ReadKey();

        }
    }
}
