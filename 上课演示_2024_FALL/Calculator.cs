namespace 上课演示_2024_FALL;

public class Calculator {
    // 加法
    public int Add(int a, int b) {
        return a + b;
    }

    // 除法
    public double Divide(int a, int b) {
        if (b == 0) {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return (double)a / b;
    }

    // 乘法
    public int Multiply(int a, int b) {
        return a * b;
    }

    // 减法
    public int Subtract(int a, int b) {
        return a - b;
    }
}