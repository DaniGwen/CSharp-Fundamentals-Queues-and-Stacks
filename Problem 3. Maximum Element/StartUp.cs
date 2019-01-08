using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Maximum_Element
{
	class StartUp
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < n; i++)
			{
				//reading commands

				var input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				// Push = 1
				// delete/Pop = 2
				// print maximum = 3

				switch (input[0])
				{
					case 1:
						stack.Push(input[1]);
						Console.WriteLine("Pushing: " + input[1]);
						break;
					case 2:
						stack.Pop();
						break;
					case 3:
						Console.WriteLine("Max number is: " + stack.Max());
						break;
					default:
						break;
				}
			}
		}
	}
}
