using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Simple_Text_Editor
{
	class Program
	{
		static void Main(string[] args)
		{
			//•	1 someString - appends someString to the end of the text
			//•	2 count - erases the last count elements from the text
			//•	3 index - returns the element at position index from the text
			//•	4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation

			int n = int.Parse(Console.ReadLine());
			
			Stack<string> stack_History = new Stack<string>();
			var text = new StringBuilder();

		
			var argumentStr = "";
			var argumentIndex = 0;

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ');
				int command = int.Parse(input[0]);

				switch (command)
				{
					case 1:
						if (input.Length > 0)
						{
							argumentStr = input[1];
							stack_History.Push(text.ToString());
							text.Append(argumentStr);
						}
						break;
					case 2:
						if (input.Length > 0)
						{
							argumentIndex = int.Parse(input[1]);
							stack_History.Push(text.ToString());
							if (argumentIndex > text.Length)
							{
								text.Clear();
								break;
							}
						}
						text.Remove(text.Length - argumentIndex, argumentIndex);
						break;
					case 3:
						if (input.Length > 0)
						{
							argumentIndex = int.Parse(input[1]);
							Console.WriteLine(text[argumentIndex - 1]);
						}
						break;
					case 4:
						text.Clear();
						text.Append(stack_History.Pop());
						break;
				}
			}

		}
	}
}
