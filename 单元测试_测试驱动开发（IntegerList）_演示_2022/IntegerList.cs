namespace 单元测试_测试驱动开发_IntegerList__演示_2022 {
    public class IntegerList {
        private int[] _elements;

        public int Count {
            get { return _elements.Length; }
        }

        public int this[int index] {
            get { return _elements[index]; }
        }

        public void Add(int value) {
            int newIndex;

            if (_elements != null) {
                var newElements = new int[_elements.Length + 1];

                for (var i = 0; i < _elements.Length; i++) {
                    newElements[i] = _elements[i];
                }

                newIndex = _elements.Length;
                _elements = newElements;
            }
            else {
                _elements = new int[1];
                newIndex = 0;
            }

            _elements[newIndex] = value;
        }

        public string ToString() {
            return string.Join(",", _elements);
        }
    }
}