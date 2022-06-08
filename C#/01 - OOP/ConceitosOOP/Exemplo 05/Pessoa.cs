using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_05
{
	internal class Pessoa
	{
		private string Nome;
		private int Idade;

		public Pessoa(string Nome = "<Unknown>", int Idade = 0)
		{
			this.Nome = Nome;
			this.Idade = Idade;
		}
	}
}
