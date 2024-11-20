namespace 单元测试_测试驱动开发_Money类__演示_2022 {
    public class Dollar {
        private decimal _amount;

        public Dollar(decimal amount) {
            _amount = amount;
        }

        public decimal Amount {
            get { return _amount; }
            set { _amount = value; }
        }

        public decimal Times(int quantity) {
            return _amount * quantity;
        }
    }
}