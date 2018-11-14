//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Serialization;
//using System.Xml;
//using System.IO;

//namespace project1
//{
//    public class OrderService
//    {
//        public List<OrderDetail> testList = new List<OrderDetail>();
//        XmlSerializer xs = new XmlSerializer(typeof(List<OrderDetail>));
//        public void Inxml()
//        {
//            using (FileStream fs = new FileStream("people.xml", FileMode.Open))
//            {
//                testList = (List<OrderDetail>)xs.Deserialize(fs);
//            }
//        }
//        public void Addorder()
//        {
//            OrderDetail a = new OrderDetail();
//            Console.WriteLine("请依次输入商品编号、商品名字、客户姓名、商品金额");
//            a.id = Console.ReadLine();
//            a.name = Console.ReadLine();
//            a.customer = Console.ReadLine();
//            a.money = Convert.ToInt32(Console.ReadLine());
//            testList.Add(a);

//            using (FileStream fs = new FileStream("people.xml", FileMode.Create))
//            {
//                xs.Serialize(fs, testList);
//            }


//        }



//        public void ShowList()
//        {
//            foreach (OrderDetail s in testList)
//            {
//                Console.WriteLine(s.ToString());
//            }
//        }
//        public void DeletList()
//        {
//            try
//            {
//                Console.WriteLine(" 请输入删除第几个：");
//                string a = Console.ReadLine();
//                int b = Convert.ToInt32(a);
//                testList.RemoveAt(b - 1);
//            }
//            catch { Console.WriteLine("请输入阿拉伯数字，并删除存在的数据"); }
//        }
//        public void ChangeList()
//        {
//            OrderDetail a = new OrderDetail();
//            Console.WriteLine("输入需要更改的商品编号：");
//            a.id = Console.ReadLine();
//            foreach (OrderDetail s in testList)
//            {
//                if (a.id == s.id)
//                {
//                    Console.WriteLine("输入新的商品名字、客户名字、商品金额");
//                    s.name = Console.ReadLine();
//                    s.customer = Console.ReadLine();
//                    s.money = Convert.ToInt32(Console.ReadLine());
//                }
//            };
//        }
//        public void FindList()
//        {
//            OrderDetail a = new OrderDetail();
//            Console.WriteLine("请输入 1：按单号查找\t2：按商品名字\t3：按客户查找\t4：查找金额大于10000的订单");
//            string b = Console.ReadLine();
//            switch (b)
//            {
//                case "1":
//                    Console.WriteLine("输入商品单号：");
//                    a.id = Console.ReadLine();
//                    var i = from n in testList where n.id == a.id select n;
//                    foreach (OrderDetail od in i)
//                    {
//                        Console.WriteLine(od.ToString());
//                    }
//                    break;
//                case "2":
//                    Console.WriteLine("输入商品名字：");
//                    a.name = Console.ReadLine();
//                    var x = from n in testList where n.name == a.name select n;
//                    foreach (OrderDetail od in x)
//                    {
//                        Console.WriteLine(od.ToString());
//                    }
//                    break;
//                case "3":
//                    Console.WriteLine("输入客户名字：");
//                    a.customer = Console.ReadLine(); foreach (OrderDetail s in testList)
//                    {
//                        if (a.name == s.name) { Console.WriteLine("订单编号: " + s.id + " 商品名称: " + s.name + " 客户: " + s.customer); }
//                    };
//                    break;
//                case "4":
//                    var m = from n in testList where n.money > 10000 select n;
//                    foreach (OrderDetail od in m)
//                    {
//                        Console.WriteLine(od.ToString());
//                    }
//                    break;
//                default:
//                    Console.WriteLine("按规则出牌");
//                    break;
//            }

//        }
//    }
//}
