using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int> stck = new Stack<int>();
			for (int i = 0; i <= 10; i++)
			{
				stck.Push(new Node<int>(i));
			}
			stck.Print();
			stck.Pop();
			stck.Print();
			Console.WriteLine(stck.Top());
			Console.WriteLine(stck.IsEmpty()); 
			Console.ReadKey();
		}
	}
}
