using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class Person
	{
		public string CPF { get; }
		public string Name { get; }
		public int Age { get; }

		public Person(string CPF, string Name, int Age)
		{
			this.CPF = CPF;
			this.Name = Name;
			this.Age = Age;
		}
	}
}
