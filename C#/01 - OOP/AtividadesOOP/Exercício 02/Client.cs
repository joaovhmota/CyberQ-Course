using System;

namespace Exercício_02
{
	internal class Client
	{
		private string _Name;
		private string _Agency;
		private string _CheckingAccount;
		private string _Password;
		private double _Balance;
		private double _Savings;
		private string _Historic;

		public string Name { get => _Name; set => _Name = value; }
		public string Agency { get => _Agency; set => _Agency = value; }
		public string CheckingAccount { get => _CheckingAccount; set => _CheckingAccount = value; }
		public string Password { get => _Password; set => _Password = value; }
		public double Balance { get => _Balance; set => _Balance = value; }
		public double Savings { get => _Savings; set => _Savings = value; }
		public string Historic { get => _Historic; set => _Historic = value; }
	}
}
