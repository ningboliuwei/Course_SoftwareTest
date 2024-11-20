#region

using System;

#endregion

namespace 单元测试_Calculator {
    public class Calculator {
        public int Add(int a, int b) {
            return a + b;
        }

        /*
         * Bubble Sort
         */

        public int[] BubbleSort(int[] array) {
            if (null == array) {
                Console.Error.WriteLine("parameter shouldn't be null!");

                return new int[] { };
            }

            for (var i = 0; i < array.Length - 1; ++i) {
                var swap = false;

                for (var j = 1; j < array.Length - i - 1; ++j) {
                    if (array[j] > array[j + 1]) {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swap = true;
                    }
                }

                if (!swap) {
                    return array;
                }
            }

            return array;
        }

        public int Divide(int a, int b) {
            return a / b;
        }

        public int Minus(int a, int b) {
            return a - b;
        }

        public int Multiply(int a, int b) {
            return a * b;
        }

        private class CaculatorTest {
            public void BubbleSortTest() {
                // Assert.AreSame(new int[]{9,8,7}, (new Caculator()).BubbleSort(new int[]{9,8,7}));
            }
        }
    }
}