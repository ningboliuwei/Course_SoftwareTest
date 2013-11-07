using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单元测试_两数相加
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Caculate caculate = new Caculate();

            Console.Write(caculate.AddTwoNumbers(x,y));
            Console.ReadLine();
        }

      
    }
}
