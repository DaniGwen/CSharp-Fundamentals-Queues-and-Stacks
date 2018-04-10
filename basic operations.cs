using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Basic_Stack_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			Stack<int> stack = new Stack<int>();
			int howManyToPUSH = input[0];
			int howManyToPOP = input[1];
			int elementToLOOK = input[2];

			for (int i = 0; i < howManyToPUSH; i++)
			{
				stack.Push(nums[i]);
			}

			for (int i = 0; i < howManyToPOP; i++)
			{
				stack.Pop();
			}

			if (stack.Contains(elementToLOOK))
			{
				Console.WriteLine("true");
			}
			else if (stack.Count == 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				Console.WriteLine(stack.Min());
			}
		}
	}
}
