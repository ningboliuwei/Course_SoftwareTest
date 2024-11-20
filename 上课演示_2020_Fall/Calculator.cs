#region

using System;

#endregion

namespace 上课演示_2020_Fall {
    public class Calculator {
        public int Add(int x, int y) {
            var result = x + y;

            return result;
        }

        public double Div(int x, int y) {
            if (y == 0) {
                throw new NullReferenceException();
            }

            return x / y;
        }

        public int Sub(int x, int y) {
            var result = x - y;

            return result;
        }
    }
}