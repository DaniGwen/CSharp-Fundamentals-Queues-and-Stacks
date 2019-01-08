using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Basic_Stack_Operations
{
	class StartUp
	{
		static void Main()
		{
			var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int n = input[0];
			int s = input[1];
			int x = input[2];

			Stack<int> stack = new Stack<int>();
			var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

			for (int i = 0; i < n; i++)
			{
				stack.Push(elements[i]);
			}

			for (int i = 0; i < s; i++)
			{
				stack.Pop();
			}

			foreach (var item in stack)
			{
				if (x == item)
				{
					Console.WriteLine("true");
					return;
				}
			}

			if (stack.Count == 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				var smallestNum = stack.Min();
				Console.WriteLine(smallestNum);
			}
		}
	}
}
