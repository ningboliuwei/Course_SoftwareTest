using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单元测试_测试驱动开发_Money类__演示
{
    class Dollar
    {
        private double m_amount;

        public Dollar()
        {

        }

        public Dollar(double amount)
        {
            m_amount = amount;
        }

        public double Amount
        {
            get { return m_amount; }
        }

        public void Times(int multiplier)
        {
            m_amount = m_amount * multiplier;
        }

        public bool EqualsTo(Dollar dollar)
        {
            return this.Amount == dollar.Amount;
        }

    }
}
