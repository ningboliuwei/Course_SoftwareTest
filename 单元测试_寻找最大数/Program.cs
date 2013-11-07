namespace 单元测试_寻找最大数
{
    using System;

    internal class Program
{
		private static void Main(string[] args)
		{
		    int largest;

		    //largest = Cmp.Largest(new int[] { 3, 4, 5 });
		    //largest = Cmp.Largest(new int[] { 5, 4, 3 });
            largest = Cmp.Largest(new int[] { 4, 5, 3 });

            Console.WriteLine(largest);
		    Console.ReadLine();//防止Console关闭
		}
	}
}