#region

using NUnit.Framework;

#endregion

namespace 上课演示_2024_FALL;

[TestFixture]
public class CalculatorTests {
// 在每个测试方法执行之前运行
    [SetUp]
    public void SetUp() {
        // 初始化工作：在每个测试方法前创建一个新的 Calculator 实例
        this._calculator = new Calculator();
        Console.WriteLine("SetUp：创建一个新的 Calculator 实例");
    }

// 在每个测试方法执行之后运行
    [TearDown]
    public void TearDown() {
        // 清理工作：这里可以释放资源，或者重置状态
        Console.WriteLine("TearDown：清理工作（如果需要的话）");
    }

    private Calculator _calculator;

// 加法测试方法
    [TestCase(10, 5, 15)]
    [TestCase(0, 0, 0)]
    [TestCase(-5, -5, -10)]
    [TestCase(100, 250, 350)]
    public void Add_Tests(int a, int b, int expected) {
        // Act
        var result = this._calculator.Add(a, b);
        // Assert
        Assert.AreEqual(expected, result); // 断言结果是否等于预期值
    }

// 减法测试方法
    [TestCase(10, 5, 5)]
    [TestCase(0, 0, 0)]
    [TestCase(-5, -5, 0)]
    [TestCase(100, 250, -150)]
    [TestCase(-100, 50, -150)]
    public void Subtract_Tests(int a, int b, int expected) {
        // Act
        var result = this._calculator.Subtract(a, b);
        // Assert
        Assert.AreEqual(expected, result); // 断言结果是否等于预期值
    }

    // 乘法测试方法
    [TestCase(10, 5, 50)]
    [TestCase(0, 0, 0)]
    [TestCase(-5, -5, 25)]
    [TestCase(100, 250, 25000)]
    [TestCase(-10, 5, -50)]
    public void Multiply_Tests(int a, int b, int expected) {
        // Act
        var result = this._calculator.Multiply(a, b);
        // Assert
        Assert.AreEqual(expected, result); // 断言结果是否等于预期值
    }

    // 除法测试方法
    [TestCase(10, 5, 2)]
    [TestCase(0, 1, 0)]
    [TestCase(-10, -5, 2)]
    [TestCase(100, 25, 4)]
    [TestCase(-100, 50, -2)]
    public void Divide_Tests(int a, int b, double expected) {
        // Act
        var result = this._calculator.Divide(a, b);
        // Assert
        Assert.AreEqual(expected, result); // 断言结果是否等于预期值
    }

    [Test]
    public void Divide_ByZero_ThrowsArgumentException() {
        // Act & Assert：验证除以零时抛出 ArgumentException 异常
        var ex = Assert.Throws<DivideByZeroException>(() => 
            _calculator.Divide(10, 0));
        // Assert：验证异常消息
        Assert.AreEqual("Cannot divide by zero.", ex.Message);
    }
}