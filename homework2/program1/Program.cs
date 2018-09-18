using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数：");
        
            int b = 2;
            string c = "";
            c = Console.ReadLine();
            int a = Int32.Parse(c);
            Console.WriteLine("所有的素数因子为：");
            while (a >= b)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b);
                    a /= b;
                }
                else
                    b++;
            }
            if (a != 1)
                Console.WriteLine("a ");
        }
    }
}
