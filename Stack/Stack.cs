using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	class Node<T>
	{
		public Node<T> next;
		public T value;
		public int index = -1;
		public Node(T value)
		{
			this.value = value;
		}
	}

	class Stack<T>
	{
		Node<T> stack;
		Node<T> first;
		Node<T> top;
		public int index = -1;

		public void Push(Node<T> NewNode)
		{
			if(stack != null)
			{
				index++;
				GetLast().next = NewNode;
				top = GetLast();
				return;
			}
			stack = NewNode;
			first = stack;
		}

		public Node<T> GetLast()
		{
			Node<T> current = stack;
			while(current.next != null)
			{
				current = current.next;
			}
			return current;
		}

		public void Print()
		{
			Node<T> First = first;
			while (First != top)
			{
				First = First.next;
				Console.WriteLine(First.value);
				
			}
			Console.WriteLine();
		}

		public void Pop()
		{
			Node<T> current = stack;
			while(current.next != top) 
			{
				current = current.next;
			}
			top = null;
			top = current;
		}

		public T Top()
		{
			Node<T> current = stack;
			T Value;
			while(current.next != top)
			{
				current = current.next;
			}
			Value = current.value;

			return Value;
		}
		public bool IsEmpty()
		{
			bool isEmpty = true;

			if (index > 0)
			{
				isEmpty = false;
			}

			return isEmpty;
		}
	}

}
