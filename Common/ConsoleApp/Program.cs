using Common;
using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
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
            Console.WriteLine(StringExt.NullSqlDateTime);

            //Console.WriteLine(res);

            //Console.WriteLine(num.Match(pattern));
            var list = TestData.GetOrderList();
            //output data
            list.ForEach(i => Console.WriteLine(string.Format("OrderId:{0}, SerialId:{1}, Name:{2}",i.OrderId,i.SerialId,i.Name)));

            Console.WriteLine("Input OrderId  ");
            while (true)
            {
                var str = Console.ReadLine();
                if (str == "exit")
                {
                    break;
                }
                try
                {
                    var first = list.Where(i => i.OrderId == str).First();//查询first,序列中不存在 会报异常
                    //PrintOrderEntity(first);
                    var firstOrdefault = list.Where(i => i.OrderId == str).FirstOrDefault();//查询first，序列中不存在，返回null
                    PrintOrderEntity(firstOrdefault);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ex:{0}", ex.ToString());

                }
            }
            
            
            Console.ReadKey();
        }

        public static void PrintOrderEntity(Order order)
        {
            Console.WriteLine(string.Format("OrderId:{0}, SerialId:{1}, Name:{2}", order.OrderId, order.SerialId, order.Name));
        } 
        
    }
}
