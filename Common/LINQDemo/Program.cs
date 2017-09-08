using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var src1 = Data.GetPersonlist();
            var count = src1.Count(t => ((t.id == 1) || (t.id == 5)));
            Console.WriteLine("{0}__", count);
            var src2 = Data.GetPetlist();

            var res = (from c in src1
                       join d in src2
                       on new { ID = c.id, Name = c.Name }
                       equals new { ID = d.id, Name = d.Name }
                       select new { ID = d.id, Name = d.Name, Owner = d.Owner }).ToList();
            foreach (var item in res)
            {
                Console.WriteLine("{0},{1},{2}",item.ID,item.Name,item.Owner);
            }
            Console.ReadKey();
        }



    }
}
