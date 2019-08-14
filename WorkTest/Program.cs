using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTest
{
    class Program
    {
        public static int times = 30;
        public static int Foo(int i ,int j)
        {
            times--;
            if(times <= 0)
            {
                return 0;
            }
            Console.WriteLine(i);
                return Foo(i + j, j = i);
        }
        static void Main(string[] args)
        {
            int test = Foo(1,1);

            Console.ReadLine();
        }
    }
}
