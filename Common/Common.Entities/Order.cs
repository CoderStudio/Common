using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Order
    {
        public Order()
        {
            OrderId = "";
            SerialId = "";
            Name = ""; 
            
        }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        public string SerialId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
    }
}
