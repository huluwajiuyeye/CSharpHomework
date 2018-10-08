using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    public class Order
    {
        public void Start(OrderService a)
        {
            bool c = true;
            while (c)
            {
                Console.WriteLine("请输入 1：添加订单");
                Console.WriteLine("       2：删除订单");
                Console.WriteLine("       3：更改订单");
                Console.WriteLine("       4：查找订单");
                Console.WriteLine("       5：浏览订单");
                Console.WriteLine("       6：结束操作");
                string b = Console.ReadLine();
                switch (b)
                {
                    case "1": a.Addorder(); break;
                    case "2": a.DeletList(); break;
                    case "3": a.ChangeList(); break;
                    case "4": a.FindList(); break;
                    case "5": a.ShowList(); break;
                    case "6": c = false; break;
                    default:
                        Console.WriteLine("大哥守点规矩好吧");
                        break;

                }
            }
    }
    public class OrderDetails
    {
        public String id; 
        public String name;
        public String customer;
    }
    public class OrderService
    {
        public List<OrderDetails> testList = new List<OrderDetails>();
        public void Addorder()
        {
            OrderDetails a = new OrderDetails();
                Console.WriteLine("输入商品编号：");
                a.id=Console.ReadLine();
                Console.WriteLine("输入商品名字：");
                a.name = Console.ReadLine();
                Console.WriteLine("输入客户名字：");
                a.customer = Console.ReadLine();
            testList.Add(a);
        }
        public void ShowList()
        {
            foreach (OrderDetails s in testList)
            {
                Console.Write("订单编号: "+s.id);
                Console.Write(" 商品名称: " + s.name);
                Console.WriteLine(" 客户: " + s.customer);
            }
        }
            public void DeletList()
            {
                try {
                    Console.WriteLine(" 请输入删除第几个：");
                    string a = Console.ReadLine();
                    int b = Convert.ToInt32(a);
                    testList.RemoveAt(b - 1);
                }
                catch { Console.WriteLine("请输入阿拉伯数字，并删除存在的数据"); }
            }
        public void ChangeList()
        {
                OrderDetails a = new OrderDetails();
                Console.WriteLine("输入需要更改的商品编号：");
                a.id = Console.ReadLine();
                foreach (OrderDetails s in testList)
                {
                    if (a.id == s.id){
                        Console.WriteLine("输入新商品名字：");
                        s.name = Console.ReadLine();
                        Console.WriteLine("输入新客户名字：");
                        s.customer = Console.ReadLine();
                    }
                };
            }
        public void FindList()
        {
                OrderDetails a = new OrderDetails();
                Console.WriteLine("请输入 1：按单号查找");
                Console.WriteLine("       2：按商品名字");
                Console.WriteLine("       3：按客户查找");
                string b = Console.ReadLine();
                switch (b)
                {
                    case "1":
                       
                            Console.WriteLine("输入需要查找的商品编号：");
                            a.id = Console.ReadLine();
                            foreach (OrderDetails s in testList)
                            {
                                if (a.id == s.id) { Console.WriteLine("订单编号: " + s.id + " 商品名称: " + s.name + " 客户: " + s.customer); }
                            };

                        break;
                    case "2":
                        Console.WriteLine("输入商品名字：");
                        a.name = Console.ReadLine(); foreach (OrderDetails s in testList)
                        {
                            if (a.name == s.name) { Console.WriteLine("订单编号: " + s.id + " 商品名称: " + s.name + " 客户: " + s.customer); }
                        };
                        break;
                    case "3":
                        Console.WriteLine("输入客户名字：");
                        a.customer = Console.ReadLine(); foreach (OrderDetails s in testList)
                        {
                            if (a.name == s.name) { Console.WriteLine("订单编号: " + s.id + " 商品名称: " + s.name + " 客户: " + s.customer); }
                        };
                        break;
                    default:
                        Console.WriteLine("按规则出牌");
                        break;
                }
                
            }

    }
    class Program
    {
        static void Main(string[] args)
        {
                Order order = new Order();
                OrderService a = new OrderService();
                order.Start(a);
            }
            
        }
    }
}
