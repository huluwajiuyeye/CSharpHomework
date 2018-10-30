using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class OrderDetail
    {
        public String id;
        public String name;
        public String customer;
        public int money;
        public override string ToString()
        {
            return "商品编号为:" + id + "\t商品名称：" + name + "\t顾客姓名：" + name + "\t商品金额：" + money;
        }
    }
}
