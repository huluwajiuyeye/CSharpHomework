using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project1
{
            
            
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
    