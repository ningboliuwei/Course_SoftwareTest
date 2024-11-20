namespace 单元测试_测试驱动开发_Money类__演示 {
    internal class Franc : Money {
        public Franc() {
            m_currency = "CHF";
        }

        public Franc(double amount)
            : base(amount) {
            m_currency = "CHF";
        }
    }
}