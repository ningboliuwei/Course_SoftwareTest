namespace 单元测试_测试驱动开发_Money类__演示 {
    internal class Money {
        protected double m_amount;

        protected string m_currency;

        public Money() {
        }

        public Money(double amount) {
            m_amount = amount;
        }

        public double Amount {
            get { return m_amount; }
        }

        public string Currency {
            get { return m_currency; }
        }

        public bool EqualsTo(Money money) {
            var bank = new Bank();
            // return this.Amount * bank.GetRate() == money.Amount;
            return true;
        }

        public void Times(int multiplier) {
            m_amount = m_amount * multiplier;
        }
    }
}