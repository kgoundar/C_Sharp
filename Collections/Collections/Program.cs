using System;
using System.Collections.Generic;

namespace Collections
{
	class Program
	{
		//The main function
		static void Main(string[] args)
		{
			Stack<string> st = new Stack<string>();

			//Adding elements to the stack
			st.Push("A");
			st.Push("B");
			st.Push("C");
			st.Push("D");

			//Removing elements to the stack
			Console.WriteLine(st.Pop());
			Console.WriteLine(st.Pop());
			Console.WriteLine(st.Pop());
			Console.WriteLine(st.Pop());

			Console.Read();
		}
	}
}
