using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_06
{
	internal class Person
	{
		protected string Name = "<Unknown>";
		protected int Age = -1;

		public Person(string Name = "<Unknown>", int Age = -1)
		{
			this.Name = Name;
			this.Age = Age;
		}

		public void Introduce()
		{
			Console.WriteLine($"Hello! My name is {this.Name} and I am {this.Age} years old");
		}
	}
}
