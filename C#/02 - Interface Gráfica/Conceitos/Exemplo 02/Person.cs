using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_02
{
	internal class Person
	{
		private string _Nome = "";
		private int _Idade = 0;

		public Person(string Nome, int Idade)
		{
			this.Nome = Nome;
			this._Idade = Idade;
		}

		public string Nome { get => _Nome; set => _Nome = value; }
		public int Idade { get => _Idade; set => _Idade = value; }

		public override string ToString()
		{
			return Nome;
		}
	}
}
