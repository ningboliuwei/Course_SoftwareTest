namespace 单元测试_测试驱动开发_Money类__演示 {
    internal class Dollar : Money {
        public Dollar() {
            m_currency = "USD";
        }

        public Dollar(double amount)
            : base(amount) {
            m_currency = "USD";
        }
    }
}