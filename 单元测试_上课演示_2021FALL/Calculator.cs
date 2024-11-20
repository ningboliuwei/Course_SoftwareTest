namespace 单元测试_上课演示_2021FALL {
    public class Calculator {
        public int Add(int x, int y) {
            return x + y;
        }

        public double Div(int x, int y) {
            if (y == 0) {
                throw new DivideByZeroException();
            }

            return x / y;
        }

        public int Sub(int x, int y) {
            return x - y;
        }
    }
}