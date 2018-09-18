using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("先输入数组元素的个数，再输入你想操作的数组");
            string c = "";
            c = Console.ReadLine();
            int a = Int32.Parse(c);
            int[] b = new int[a];
            int s = 0;
            for (int i=0; i<a;i++)
            {
                
                string num = Console.ReadLine();
                b[i] = Int32.Parse(num);
                s = b[i] + s;
            }
            int aver = s / a;
            int max=0, min=1000;
            for (int i = 0; i < a-1; i++)
            {
                if (max < b[i])
                    max = b[i];
            }
            for (int i = 0; i < a-1; i++)
            {
                if (min > b[i])
                min = b[i];
            }
     
            Console.WriteLine("平均数为" + aver);
            Console.WriteLine("和为" + s);
            Console.WriteLine("最大值为"+ max);
            Console.WriteLine("最小值为" + min);
        }
    }
}
