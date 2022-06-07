using System;

namespace Exercício_04
{
	internal class Contact
	{
		// Attributes
		private string _Name = "<Unknown>";
		private string _Email = "<Unknown>";
		private string _Phone = "<Unknown>";
		private string _City = "<Unknown>";

		// Getters & Setters
		public string Name { get => _Name; set => _Name = value; }
		public string Email { get => _Email; set => _Email = value; }
		public string Phone { get => _Phone; set => _Phone = value; }
		public string City { get => _City; set => _City = value; }

		public Contact CreateContact()
		{
			Console.Write(" ・ Informe o nome do contato: "); this.Name = Console.ReadLine()!;
			Console.Write(" ・ Informe o email do contato: "); this.Email = Console.ReadLine()!;
			Console.Write(" ・ Informe o número de telefone do contato: "); this.Phone = Console.ReadLine()!;
			Console.Write(" ・ Informe a cidade em que o contato reside: "); this.City = Console.ReadLine()!;
			return this;
		}

		public Contact EditContact()
		{
			Console.Write(" ・ Informe o novo nome do contato: "); this.Name = Console.ReadLine()!;
			Console.Write(" ・ Informe o novo email do contato: "); this.Email = Console.ReadLine()!;
			Console.Write(" ・ Informe o novo número de telefone do contato: "); this.Phone = Console.ReadLine()!;
			Console.Write(" ・ Informe a nova cidade em que o contato reside: "); this.City = Console.ReadLine()!;
			return this;
		}
	}
}
