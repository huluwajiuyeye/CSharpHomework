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
            string a = "";
            string b = "";
            int x, y = 0;
            System.Console.Write("请输入两个数字：");
            a = Console.ReadLine();
            b = Console.ReadLine();
            x = Int32.Parse(a);
            y = Int32.Parse(b);
            System.Console.Write(x * y);
        }
    }
}
