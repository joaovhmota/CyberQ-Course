using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_17
{
	internal class Person
	{
		public string Name   { get; set; }
		public int    Age    { get; set; }
		public string State  { get; set; }
		public string Gender { get; set; }

		public Person(string Name, int Age, string State, string Gender)
		{
			this.Name = Name;
			this.Age = Age;
			this.State = State;
			this.Gender = Gender;
		}
	}
}
