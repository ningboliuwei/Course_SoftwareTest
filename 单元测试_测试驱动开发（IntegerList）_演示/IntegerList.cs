using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单元测试_测试驱动开发_IntegerList__演示
{
	using System.Collections;

	class IntegerList:IEnumerable
	{
		private int[] elements;

		public IntegerList()
		{

		}

		public void Add(int value)
		{
			int newIndex;
			if (elements != null)
			{
				int[] newElements = new int[elements.Length + 1];
				for (int i = 0; i < elements.Length;
					 i++)
				{
					newElements[i] = elements[i];
				}
				newIndex = elements.Length;
				elements = newElements;
			}
			else
			{
				elements = new int[1];
				newIndex = 0;
			}
			elements[newIndex] = value;
		}

		public int this[int index]
		{
			get
			{
				return elements[index];
			}
		}

		public int Count
		{
			get
			{
				return elements.Length;
			}
		}

		public string ToString()
		{
			string[] elementsString = new string[elements.Length];

			for (int i = 0; i < elements.Length; i++)
			{
				elementsString[i] = elements[i].ToString();
			}
			return String.Join(",", elementsString);
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
}
