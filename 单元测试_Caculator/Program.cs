#region

using System;

#endregion

namespace 单元测试_Calculator {
    internal class Program {
        private static void Main(string[] args) {
            var cal = new Calculator();

            var result = cal.Add(1, 3);

            Console.WriteLine(result);

            int[] array = { 3, 2, 5, 7, 9 };
            var resultArray = cal.BubbleSort(array);

            for (var i = 0; i < resultArray.Length; i++) {
                Console.Write(resultArray[i] + ",");
            }

            Console.Read();
        }
    }
}