using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上课演示_2020_Fall
{
    public class Calculator
    {
        public int Add(int x, int y) {
            var result = x + y;

            return result;
        }

        public int Sub(int x, int y) {
            var result = x - y;

            return result;
        }

        public double Div(int x, int y) {
            if (y == 0) {
                throw new NullReferenceException();
            }

            return x / y;
        }
    }
}