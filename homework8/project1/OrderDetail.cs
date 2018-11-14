using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public class OrderDetail
    {
        public String id { get; set; }
        public String name { get; set; }
        public String customer { get; set; }
        public int money { get; set; }
        public long phonenumber { get; set; }
        public long ordernumber { get; set; }
        public override string ToString()
        {
            return "商品编号为:" + id + "\t商品名称：" + name + "\t顾客姓名：" + name + "\t商品金额：" + money;
        }
    }
}
