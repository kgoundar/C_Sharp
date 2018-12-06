using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
	struct Student
	{
		public int ID;
		public string Name;
	};
	class Program
	{
		static void Main(string[] args)
		{
			//Creating an object of the Student class 
			Student stud;

			//Defining the properties of the structure
			stud.ID = 1;
			stud.Name = "John";

			string ID = "" + stud.ID;

			//Display the properties of the structure
			Console.WriteLine(ID);
			Console.WriteLine(stud.Name);
			Console.Read();
		}
	}
}
