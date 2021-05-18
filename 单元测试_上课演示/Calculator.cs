using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单元测试_上课演示
{
    public class Calculator
    {
        public double Add(double x, double y) {
            return x + y;
        }

        public double Sub(double x, double y) {
            return x - y;
        }

        public double Divide(double x, double y) {
            if (y == 0) {
                throw new DivideByZeroException();
            }

            return x / y;
        }
    }
}
