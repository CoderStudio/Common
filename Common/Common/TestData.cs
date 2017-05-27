using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class TestData
    {
        public static List<Order> GetOrderList()
        {
            List<Order> list = new List<Order> {
                new Order{OrderId="100001",SerialId ="S10001",Name="Tom"},
                new Order{OrderId="100002",SerialId ="S10002",Name="Tom"},
                new Order{OrderId="100003",SerialId ="S10003",Name="Tom"},
                new Order{OrderId="100004",SerialId ="S10004",Name="Tom"},
                new Order{OrderId="100005",SerialId ="S10005",Name="Tom"},
                new Order{OrderId="100006",SerialId ="S10006",Name="Tom"}
            };

            return list;
        }

    }
}
