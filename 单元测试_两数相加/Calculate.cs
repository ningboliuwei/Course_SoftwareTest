namespace 单元测试_两数相加 {
    internal class Calculate {
        public int AddTwoNumbers(int number1, int number2) {
            var result = 0;

            result = number1 + number2;

            return result;
        }

        public float DivideTwoNumbers(int number1, int number2) {
            float result = 0;

            result = number1 / number2;

            return result;
        }

        public int FindBigger(int number1, int number2) {
            var result = 0;

            if (number1 > number2) {
                result = number1;
            }
            else {
                result = number2;
            }

            return result;
        }
    }
}