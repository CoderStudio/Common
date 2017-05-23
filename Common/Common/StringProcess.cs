using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class StringProcess
    {
        public static string BankAccountWithSpace(string accountStr)
        {
            string output = System.Text.RegularExpressions.Regex.Replace(accountStr.Trim(), @"(\w{4})", "$1 ").Trim(' ');
            return output;
        }

    }
}
