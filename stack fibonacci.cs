using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Stack_Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			long n = long.Parse(Console.ReadLine());
			Stack<long> stack = new Stack<long>();
			stack.Push(1);
			stack.Push(1);
			stack.Push(1);

			for (int i = 2; i < n; i++)
			{
				var minusOne = stack.Pop();
				var minusTwo = stack.Peek();
				stack.Push(minusOne);

				var currentFib = minusOne + minusTwo;
				stack.Push(currentFib);
			}
			Console.WriteLine(stack.Peek());
		}
	}
}
