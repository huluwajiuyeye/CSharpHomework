using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Order.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddorderTest()
        {
            List<OrderDetail> testList = new List<OrderDetail>();
            OrderDetail a = new OrderDetail();
            a.id = "123";
            testList.Add(a);
            Assert.IsNotNull(testList);
            Assert.IsNull(testList);
        }

        [TestMethod()]
        public void ShowListTest()
        {
            List<OrderDetail> testList = new List<OrderDetail>();
            foreach (OrderDetail s in testList)
            {
                Console.WriteLine(s.ToString());
            }
            Assert.IsNotNull(testList);
            Assert.IsNull(testList);
        }

        [TestMethod()]
        public void DeletListTest()
        {
            List<OrderDetail> testList = new List<OrderDetail>();
            testList.RemoveAt(1);
            Assert.IsNull(testList);
            Assert.IsNotNull(testList);
        }
    }
}