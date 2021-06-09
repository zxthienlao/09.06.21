using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class List<T>
	{
		public void Add(T value)
		{
			Node<T> node = new Node<T>();
			node.value = value;
			if (firstElement == null)
			{
				firstElement = node;
			}
			else
			{
				GetLast().next = node;
			}


		}
		Node<T> firstElement;
		Node<T> GetLast()
		{
			Node<T> last = firstElement;

			while (last.next != null)
			{
				last = last.next;
			}
			return last;
		}
		public void Print()
		{
			Node<T> last = GetFirst();
			while (last != null)
			{
				Console.WriteLine(last.value);
				last = last.next;

			}
		}
		public void AddFront(T value) // выводит предыдущий элемент
		{
			Node<T> noded = new Node<T>();
			noded.value = value;

			if (firstElement == null)
			{
				firstElement = noded;
			}
			else
			{
				noded.next = GetFirst();
				noded.next.prev = noded;
			}
		}
		Node<T> GetFirst()

		{
			Node<T> last = firstElement;

			while (last.prev != null)
			{
				last = last.prev;
			}
			return last;
		}
	}
}
