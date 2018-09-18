using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] b = new bool[100];
            for (int i = 0; i < 100; i++)
            {
                b[i] = true;
            }
            for (int i = 2;i<100; i++)
            {
                if (b[i - 2] == true)
                {
                    for (int a = i; a < 100; a++)
                    {
                        if (a % i == 0) b[a - 2] = false;
                    }
                    Console.WriteLine(i);
                }
            }
        }
        
    }
}
