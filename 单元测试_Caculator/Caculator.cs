using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单元测试_Caculator
{
	

	public class Caculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        /*
         * Bubble Sort
         */

        public int[] BubbleSort(int[] array)
        {
            if (null == array)
            {
                Console.Error.WriteLine("parameter shouldn't be null!");

                return new int[] { };
            }

            for (int i = 0; i < array.Length-1 ; ++i)
            {
                bool swap = false;

                for (int j = 1; j < array.Length - i - 1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swap = true;
                    }
                }

                if (!swap)
                {
                    return array;
                }
            }

            return array;
        }

		private class CaculatorTest
		{
			public void BubbleSortTest()
			{
				// Assert.AreSame(new int[]{9,8,7}, (new Caculator()).BubbleSort(new int[]{9,8,7}));
			}
		}
    }
}

