using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单元测试_Caculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Caculator cal = new Caculator();

            int result = cal.Add(1, 3);

            Console.WriteLine(result);


            int[] array = new int[] {3, 2, 5, 7, 9};
            int[] resultArray ; 
            resultArray= cal.BubbleSort(array);

            for(int i = 0; i < resultArray.Length;i++)
            {
               Console.Write(resultArray[i] + ",");
            }

            Console.Read();
        }
    }
}
