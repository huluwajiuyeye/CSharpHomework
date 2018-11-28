using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace project1
{
    public class OrderDetail
    {
        [Key]
        public String Id { get; set; }
        public String Name { get; set; }
        public String Customer { get; set; }
        public int Money { get; set; }
        public long Phonenumber { get; set; }
        public long Ordernumber { get; set; }
        public override string ToString()
        {
            return "商品编号为:" + Id + "\t商品名称：" + Name + "\t顾客姓名：" + Customer + "\t商品金额：" + Money;
        }
    }
}
