using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit_Demo
{
    public class Calculation
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public float Divide(float x, float y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }

            return x / y;
        }
    }
}