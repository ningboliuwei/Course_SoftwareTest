using System;

namespace 上课演示_2021_SPRING
{
    class Program
    {
        static void Main(string[] args) {
            var calculator = new Calculator();
            var actualResult = calculator.Add(3, 5);
            Console.WriteLine(actualResult);

            Console.ReadKey();
        }
    }
}
