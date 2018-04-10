using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Balanced_Parentheses
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			var stack = new Stack<char>();
			bool isBalanced = true;

			for (int i = 0; i < input.Length; i++)
			{
				var bracket = input[i];

				if (bracket == '{' || bracket == '(' || bracket == '[')
				{
					stack.Push(bracket);
				}

				else if (bracket == '}' || bracket == ')' || bracket == ']')
				{
					if (stack[]  == null)
					{
						char openBracket = stack.Pop();
						char closingBracket = bracket;

						if (Pairing(openBracket, closingBracket) == false)
						{
							Console.WriteLine("NO");
							return;
						}
						else if (stack.Count == 0)
						{
							Console.WriteLine("NO");
							return;
						}
					}
					else
					{
						isBalanced = true;
					}
				}
			}
			if (isBalanced == true)
			{
				Console.WriteLine("YES");
			}

		}
		public static bool Pairing(char openBracket, char closingBracket)
		{
			bool isMatch = false;

			if (openBracket == '{')
			{
				if (closingBracket == '}')
				{
					isMatch = true;
				}
				else
				{
					isMatch = false;
				}
			}
			else if (openBracket == '(')
			{
				if (closingBracket == ')')
				{
					isMatch = true;
				}
				else
				{
					isMatch = false;
				}
			}
			else if (openBracket == '[')
			{
				if (closingBracket == ']')
				{
					isMatch = true;
				}
				else
				{
					isMatch = false;
				}
			}
			return isMatch;
		}
	}
}
