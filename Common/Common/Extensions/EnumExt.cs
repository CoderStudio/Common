using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extensions
{
    public static class EnumExt
    {
        public static string GetDes(this Enum value)
        {
            try
            {
                if (value == null) return "";
                var field = value.GetType().GetField(value.ToString());
                return ((DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))).Description;
            }
            catch (Exception ex)
            {
                return value.ToString();
            }
        }

        public static string GetDescription(this Enum en)
        {
            Type type = en.GetType();   //获取类型  
            MemberInfo[] memberInfos = type.GetMember(en.ToString());   //获取成员  
            if (memberInfos != null && memberInfos.Length > 0)
            {
                DescriptionAttribute[] attrs = memberInfos[0].GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];   //获取描述特性  

                if (attrs != null && attrs.Length > 0)
                {
                    return attrs[0].Description;    //返回当前描述  
                }
            }
            return en.ToString();
        }

    }
}
