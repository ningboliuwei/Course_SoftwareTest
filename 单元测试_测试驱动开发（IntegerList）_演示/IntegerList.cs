#region

using System.Collections;

#endregion

namespace 单元测试_测试驱动开发_IntegerList__演示 {
    internal class IntegerList : IEnumerable {
        private int[] elements;

        public int Count {
            get { return elements.Length; }
        }

        public int this[int index] {
            get { return elements[index]; }
        }

        public IEnumerator GetEnumerator() {
            return null;
        }

        public void Add(int value) {
            int newIndex;
            if (elements != null) {
                var newElements = new int[elements.Length + 1];
                for (var i = 0;
                     i < elements.Length;
                     i++) {
                    newElements[i] = elements[i];
                }

                newIndex = elements.Length;
                elements = newElements;
            }
            else {
                elements = new int[1];
                newIndex = 0;
            }

            elements[newIndex] = value;
        }

        public string ToString() {
            var elementsString = new string[elements.Length];

            for (var i = 0; i < elements.Length; i++) {
                elementsString[i] = elements[i].ToString();
            }

            return string.Join(",", elementsString);
        }
    }
}