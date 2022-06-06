using System;

namespace Exemplo_04
{
	internal class Person
	{
		private string _Name;
		private int _Age;

		public string Name { get => _Name; set => _Name = value; }
		public int Age { get => _Age; set => _Age = value; }

		public Person() { this._Name = ""; this.Age = 0; }
	}
}
