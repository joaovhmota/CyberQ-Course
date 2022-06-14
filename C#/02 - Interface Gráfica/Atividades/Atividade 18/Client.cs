using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_18
{
	internal class Client
	{
		public string Nome;
		public string Agencia;
		public string ContaCorrente;
		public string Senha;
		public float Saldo;
		public float Poupanca;

		public Client(string Nome, string Agencia, string ContaCorrente, string Senha, float Saldo)
		{
			this.Nome = Nome;
			this.Agencia = Agencia;
			this.ContaCorrente = ContaCorrente;
			this.Senha = Senha;
			this.Saldo = Saldo;
			this.Poupanca = 0.0f;
		}
	}
}
