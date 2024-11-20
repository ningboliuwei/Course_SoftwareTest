#region

using System;

#endregion

namespace 单元测试_两数相加 {
    internal class Program {
        private static void Main(string[] args) {
            var x = 3;
            var y = 4;

            var caculate = new Calculate();

            Console.Write(caculate.AddTwoNumbers(x, y));
            Console.ReadLine();
        }
    }
}