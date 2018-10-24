using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Menu
    {
        public void GetOrder(OrderDetail a)
        {
            a.id = Console.ReadLine();
            a.name = Console.ReadLine();
            a.customer = Console.ReadLine();
            a.money = Convert.ToInt32(Console.ReadLine());
            
        }


    }
}
