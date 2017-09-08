using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//using Common.Extensions;

namespace xmlDocdemo
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            var mobile = new List<string> { "DF13013896806"/*, "AB13776056110"*/ };//new List<test>(); //
            //var list = mobile.Select(i => "'" + i + "'").ToList();
            //Console.WriteLine("{0}",string.Join(",", list));
            //Console.WriteLine("{0}", (int)OrderCommentEnum.NoComment);

            //test = test.Replace("\\","/");
            //var date = new DateTime(2017,8,3,11,20,0);
            var datestr = "2017-08-02 11:00:00";
            var date = Convert.ToDateTime(datestr);
            if (DateTime.Now > date)
            {
                Console.WriteLine("{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            }
            else
            {
                Console.WriteLine("false");

            }


            #region MyRegion

            //string path = @"D:\xml\demo.xml";
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(path);
            //XmlNode xmlNode1 = xmlDoc.SelectSingleNode("/response/error/code");
            //XmlNode xmlNode2 = xmlDoc.SelectSingleNode("/response/error/desc");
            //string ads = xmlNode1.InnerText;
            //string ste = xmlNode2.InnerText;
            //Console.WriteLine("{0}, {1}", ads, ste);
            #endregion
            Console.ReadKey();
        }

        //public static string GetDes(this Enum value)
        //{
        //    try
        //    {
        //        if (value == null) return "";
        //        var field = value.GetType().GetField(value.ToString());
        //        return ((DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))).Description;
        //    }
        //    catch (Exception ex)
        //    {
        //        return value.ToString();
        //    }
        //}

    }
    public class test
    {
        public int id { get; set; }
        public string name { get; set; }
    }


}
