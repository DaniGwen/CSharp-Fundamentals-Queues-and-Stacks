using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Maximum_Element
{
	class Program
	{
		static void Main(string[] args)
		{
			int Nlines = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();
			for (int i = 0; i < Nlines; i++)
			{
				var inputArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				int command = inputArgs[0];
				switch (command)
				{
					case 1: stack.Push(inputArgs[1]);
						break;
					case 2: stack.Pop();
						break;
					case 3: Console.WriteLine(stack.Max());
						break;
				}

			}
		}
	}
}
