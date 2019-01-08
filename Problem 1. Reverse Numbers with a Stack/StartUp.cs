using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Reverse_Numbers_with_a_Stack
{
	class StartUp
	{
		static void Main()
		{
			Stack<int> stack = new Stack<int>();

			var input = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			for (int i = 0; i < input.Length; i++)
			{
				stack.Push(input[i]);
			}

			for (int i = 0; i < input.Length; i++)
			{
				Console.Write(stack.Pop() + " ");
			}

			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
