using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
	class Person
	{
		private
			int ID;
		public void setID(int pID)
		{
			ID = pID;
		}

		public string getID()
		{
			return ID.ToString();
		}

		public void Display()
		{
			Console.WriteLine("This is the Person class");
			
		}
	}

	//Student class inherits the Person class
	class Student : Person
	{
		private
			string Name;

		public void setName(string pName)
		{
			Name = pName;
		}

		public string getName()
		{
			return Name;
		}

		public void Display()
		{
			Console.WriteLine("This is the Student class");
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			//Creating an object of the Student class
			Student stud = new Student();
			Person per = new Student();

			per.Display();
			stud.Display();
			Console.Read();

		}
	}
}
