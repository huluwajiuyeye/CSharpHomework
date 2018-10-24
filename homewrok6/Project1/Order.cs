using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    
        public class Order
        {
            public  int Getway { get; set;}
            
            public void Start(OrderService a)
            {
            try { a.Inxml(); } catch { };
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
        }
}
