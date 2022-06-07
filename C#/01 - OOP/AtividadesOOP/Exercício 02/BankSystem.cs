using System;

namespace Exercício_02
{
	internal class BankSystem
	{
		private List<Client> clients = new List<Client>();
		private Client currentLogged;
		private bool isLogged;

		public void AddClient(Client client) 
		{
			this.clients.Add(client);
		}

		public void Login()
		{
			if (currentLogged != null) return;

			isLogged = false;
			string agency;
			string checkingAccount;
			string password;

			do
			{
				try
				{
					Console.Clear();
					Console.Write(" ・ Agência: ");
					agency = Console.ReadLine();

					Console.Write(" ・ Conta corrente: ");
					checkingAccount = Console.ReadLine();

					Console.Write(" ・ Senha: ");
					password = Console.ReadLine();

					for (int i = 0; i < clients.Count; i++)
					{
						if (agency == clients[i].Agency)
							if (checkingAccount == clients[i].CheckingAccount)
								if (password == clients[i].Password)
								{
									currentLogged = clients[i];
									isLogged = true;
									break;
								}
					}
				} catch (Exception ex)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($" ・ {ex.Message} ・ ");
					Console.ForegroundColor = ConsoleColor.White;
					Console.ReadLine();
				}
			} while (!isLogged);
			this.ShowMenu();
		}

		private void ShowMenu()
		{
			int opt;
			bool isRunning = true;
			do
			{
				try
				{
					Console.Clear();
					Console.WriteLine($" ・ Logado como: {currentLogged!.Name}");
					Console.WriteLine($" ・ Saldo atual: {currentLogged.Balance:C2}");
					Console.WriteLine($" ・ 1 - Sacar");
					Console.WriteLine($" ・ 2 - Depositar");
					Console.WriteLine($" ・ 3 - Extrato");
					Console.WriteLine($" ・ 4 - Poupança");
					Console.WriteLine($" ・ 5 - Empréstimo");
					Console.WriteLine($" ・ 6 - Saldo");
					Console.WriteLine($" ・ 7 - Logoff");
					Console.Write(">>> "); opt = Convert.ToInt32(Console.ReadLine());
					
					switch (opt)
					{
						case 1: Withdraw(); break;
						case 2: Deposit();  break;
						case 3: Historic(); break;
						case 4: Savings();  break;
						case 5: Loan();     break;
						case 6: Balance();  break;
						case 7: 
							isRunning = false;
							isLogged = false;
							currentLogged = null;
							Login();
							break;
					}

				} catch (Exception ex)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($" ・ {ex.Message} ・ ");
					Console.ForegroundColor = ConsoleColor.White;
					Console.ReadLine();
				}
			} while (isRunning);
		}

		private void Withdraw()
		{
			try
			{
				double toWithdraw;

				Console.Write(" ・ Valor a sacar: ");
				toWithdraw = Convert.ToDouble(Console.ReadLine());

				if (!(toWithdraw <= currentLogged.Balance) || !(toWithdraw > 0) ) return;

				currentLogged.Balance -= toWithdraw;
				currentLogged.Historic += $" ・ Sacou {toWithdraw:C2}\n";
			} catch(Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
			}
		}

		private void Deposit()
		{
			try
			{
				double toDeposit;

				Console.Write("Valor a sacar: ");
				toDeposit = Convert.ToDouble(Console.ReadLine());

				currentLogged.Balance += toDeposit;
				currentLogged.Historic += $" ・ Depositou {toDeposit:C2}\n";
			} catch(Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
			}
		}

		private void Historic()
		{
			Console.WriteLine(" ・ Histórico: ");
			Console.WriteLine(currentLogged.Historic);
			Console.ReadLine();
		}

		private void Savings()
		{
			try
			{
				double toSave;
				int opt;
				bool isRunning = true;
				do
				{
					Console.Clear();
					Console.WriteLine($"Sua poupança é de: {currentLogged.Savings:C2}");
					Console.WriteLine(" ・ 1 - Sacar");
					Console.WriteLine(" ・ 2 - Depositar");
					Console.WriteLine(" ・ 3 - Sair");
					Console.Write(">>> "); opt = Convert.ToInt32(Console.ReadLine());
						
					switch (opt)
					{
						case 1:
							Console.Write("Valor a sacar: ");
							toSave = Convert.ToDouble(Console.ReadLine());
							if (toSave < 0 || toSave > currentLogged.Savings) return;

							currentLogged.Balance += toSave;
							currentLogged.Savings -= toSave;
							currentLogged.Historic += $" ・ Tirou {toSave:C2} da poupança\n";
							break;
						case 2:
							Console.Write("Valor a depositar: ");
							toSave = Convert.ToDouble(Console.ReadLine());
							if (toSave < 0 || toSave > currentLogged.Balance) return;

							currentLogged.Balance -= toSave;
							currentLogged.Savings += toSave;
							currentLogged.Historic += $" ・ Colocou {toSave:C2} na poupança\n";
							break;
						case 3: isRunning = false; break;
					}


				} while (isRunning);
			} catch(Exception ex)
			{

			}
		}

		private void Loan()
		{
			try
			{
				double toWithdraw;

				Console.Write(" ・ Valor a pegar de empréstimo: ");
				toWithdraw = Convert.ToDouble(Console.ReadLine());

				if (toWithdraw > currentLogged.Balance * 10 || !(toWithdraw > 0) ) return;

				currentLogged.Balance += toWithdraw;
				currentLogged.Historic += $" ・ Pegou um empréstimo {toWithdraw:C2}\n";
			} catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
			}
		}

		private void Balance()
		{
			Console.WriteLine($" ・ {currentLogged.Name}, seu saldo atual é de {currentLogged.Balance:C2}");
			Console.ReadLine();
		}
	}
}