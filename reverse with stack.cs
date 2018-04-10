using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Reverse_Numbers_with_a_Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			Stack<int> stack = new Stack<int>(nums);
			while (stack.Count != 0 )
			{
				Console.Write(stack.Pop() + " ");
			}

		}
	}
}
