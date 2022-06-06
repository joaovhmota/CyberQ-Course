dynamic[,] clients =
{
	{ 1, "João",     "Ag1", "1234", "kingof8ball",   5000.00, "", 0.0 },
	{ 2, "Samuca",   "Ag2", "1234", "samucaPeruca",  5000.00, "", 0.0 },
	{ 3, "Budegas",  "Ag3", "1234", "éoBudegas",     5000.00, "", 0.0 },
	{ 4, "Cictor",   "Ag4", "1234", "chocolatin,é?", 5000.00, "", 0.0 },
	{ 5, "Henrique", "Ag5", "1234", "noGameMaker",   5000.00, "", 0.0 },
	{ 6, "William",  "Ag6", "1234", "1234",          5000.00, "", 0.0 },
	{ -2, "A", "A", "A", "A", 0.00, "A", 0} // Conta nula
};
string tempAgencia,
	  tempContaCorrente,
	  tempPassword;

int currentLogged = 0,
    mode = 0,
    menuOpt = 1;

double valorASacar = 0;

ConsoleKey currentKey;

do
{
	// Login Screen
	Console.Clear();
	Console.SetCursorPosition(1, 1);
	if (currentLogged == 0)
	{
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine(" ・ Nenhum usuário logado ・ ");
		Console.ForegroundColor = ConsoleColor.White;
	}
	else if (currentLogged == -1)
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine(" ・ Acesso negado! ・ ");
		Console.ForegroundColor = ConsoleColor.White;
	}
	

	Console.SetCursorPosition(1, 2); Console.WriteLine(" ・ Agência: ");
	Console.SetCursorPosition(1, 3); Console.WriteLine(" ・ Conta Corrente: ");
	Console.SetCursorPosition(1, 4); Console.WriteLine(" ・ Senha: ");

	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.SetCursorPosition(" ・ Agência: ".Length + 1, 2); tempAgencia = Console.ReadLine()!;
	Console.SetCursorPosition(" ・ Conta Corrente: ".Length + 1, 3); tempContaCorrente = Console.ReadLine()!;
	Console.SetCursorPosition(" ・ Senha: ".Length + 1, 4); tempPassword = Console.ReadLine()!;
	Console.ForegroundColor = ConsoleColor.White;

	currentLogged = -1;
	for (int l = 0; l < clients.GetLength(0); l++)
		if (tempAgencia == clients[l, 2])
			if (tempContaCorrente == clients[l, 3])
				if (tempPassword == clients[l, 4])
					currentLogged = clients[l, 0];

	if (currentLogged == -1) continue;
	else if (currentLogged == 0) continue;

	// Bank Screen

	while (true)
	{
		Console.Clear();
		switch (mode)
		{
			case 0: // Menu
				menuOpt = 1;
				while (true)
				{
					Console.SetCursorPosition(1, 1);
					Console.Write($" [ Bem vindo, ");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write($"{clients[currentLogged - 1, 1]}");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine(" ] ");
					Console.SetCursorPosition(1, 2); Console.WriteLine($" > Saldo: {clients[currentLogged, 5]:C2}");
					Console.SetCursorPosition(1, 3); Console.WriteLine(" ・ Sacar     " + (menuOpt == 1 ? " <- " : ""));
					Console.SetCursorPosition(1, 4); Console.WriteLine(" ・ Depositar " + (menuOpt == 2 ? " <- " : ""));
					Console.SetCursorPosition(1, 5); Console.WriteLine(" ・ Extrato   " + (menuOpt == 3 ? " <- " : ""));
					Console.SetCursorPosition(1, 6); Console.WriteLine(" ・ Poupança  " + (menuOpt == 4 ? " <- " : ""));
					Console.SetCursorPosition(1, 7); Console.WriteLine(" ・ Empréstimo" + (menuOpt == 5 ? " <- " : ""));
					Console.SetCursorPosition(1, 9); Console.WriteLine(" ・ Sair      " + (menuOpt == 6 ? " <- " : ""));
					currentKey = Console.ReadKey().Key;

					if (currentKey == ConsoleKey.UpArrow && menuOpt != 1)
						menuOpt--;

					if (currentKey == ConsoleKey.DownArrow && menuOpt != 6)
						menuOpt++;

					if (currentKey == ConsoleKey.Enter)
					{
						mode = menuOpt;
						break;
					}
					Console.Clear();
				}
				break;

			case 1:
				menuOpt = 1;
				while (true)
				{
					Console.SetCursorPosition(1, 1);
					Console.Write(" [ ");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write("Sacar Dinheiro");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine(" ] ");

					Console.SetCursorPosition(1, 2); Console.WriteLine($" > Saldo: {clients[currentLogged, 5]:C2}");
					Console.SetCursorPosition(1, 3); Console.WriteLine(" ・ Escolher valor" + (menuOpt == 1 ? " <- " : ""));
					Console.SetCursorPosition(1, 4); Console.WriteLine(" ・ Sair          " + (menuOpt == 2 ? " <- " : ""));
					currentKey = Console.ReadKey().Key;

					if (currentKey == ConsoleKey.UpArrow)
						if (!(menuOpt == 1))
							menuOpt--;

					if (currentKey == ConsoleKey.DownArrow)
						if (!(menuOpt == 2))
							menuOpt++;

					if (currentKey == ConsoleKey.Enter)
					{
						if (menuOpt == 1)
						{
							Console.SetCursorPosition(1, 7); Console.WriteLine(" ・ R$");
							Console.SetCursorPosition(" ・ R$".Length + 1, 7);
							try
							{
								do
								{
									valorASacar = Convert.ToDouble(Console.ReadLine()!);
									if (clients[currentLogged, 5] - valorASacar >= 0)
									{
										clients[currentLogged, 5] -= valorASacar;
										clients[currentLogged, 6] += $" ・ Sacou R${valorASacar:C2}\n";
										break;
									}
									else
									{
										Console.SetCursorPosition(1, 6);
										Console.ForegroundColor = ConsoleColor.Red;
										Console.WriteLine($" ・ [Saldo insuficiente] ・ ");
										Console.ForegroundColor = ConsoleColor.White;
										Console.ForegroundColor = ConsoleColor.Black;
										Console.SetCursorPosition(" ・ R$".Length + 1, 7);
										Console.WriteLine(valorASacar);
										Console.SetCursorPosition(" ・ R$".Length + 1, 7);
										Console.ForegroundColor = ConsoleColor.White;
									}
								} while (true);
								
							} catch (Exception ex)
							{
								Console.SetCursorPosition(1, 6);
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine($" ・ [{ex.Message}] ・ ");
								Console.ForegroundColor = ConsoleColor.White;
								Console.ForegroundColor = ConsoleColor.Black;
								Console.SetCursorPosition(" ・ R$".Length + 1, 7);
								Console.WriteLine(valorASacar);
								Console.SetCursorPosition(" ・ R$".Length + 1, 7);
								Console.ForegroundColor = ConsoleColor.White;

							}
						}
						if (menuOpt == 2) break;
					}
					Console.Clear();
				}
				menuOpt = 1;
				mode = 0;
				break;

			case 2:
				menuOpt = 1;
				while (true)
				{
					Console.SetCursorPosition(1, 1);
					Console.Write(" [ ");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write("Depositar Dinheiro");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine(" ] ");

					Console.SetCursorPosition(1, 2); Console.WriteLine($" > Saldo: {clients[currentLogged, 5]:C2}");
					Console.SetCursorPosition(1, 3); Console.WriteLine(" ・ Escolher valor" + (menuOpt == 1 ? " <- " : ""));
					Console.SetCursorPosition(1, 4); Console.WriteLine(" ・ Sair          " + (menuOpt == 2 ? " <- " : ""));
					currentKey = Console.ReadKey().Key;

					if (currentKey == ConsoleKey.UpArrow)
						if (!(menuOpt == 1))
							menuOpt--;

					if (currentKey == ConsoleKey.DownArrow)
						if (!(menuOpt == 2))
							menuOpt++;

					if (currentKey == ConsoleKey.Enter)
					{
						if (menuOpt == 1)
						{
							Console.SetCursorPosition(1, 7); Console.WriteLine(" ・ R$");
							Console.SetCursorPosition(" ・ R$".Length + 1, 7);
							try
							{
								do
								{
									valorASacar = Convert.ToDouble(Console.ReadLine()!);
									clients[currentLogged, 5] += valorASacar;
									clients[currentLogged, 6] += $" ・ Depositou R${valorASacar:C2}\n";
									break;
								} while (true);
								
							} catch (Exception ex)
							{
								Console.SetCursorPosition(1, 6);
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine($" ・ [{ex.Message}] ・ ");
								Console.ForegroundColor = ConsoleColor.White;

							}
						}
						if (menuOpt == 2) break;
					}
					Console.Clear();
				}
				menuOpt = 1;
				mode = 0;
				break;

			case 3:
				menuOpt = 1;
				while (true)
				{
					Console.SetCursorPosition(1, 1);
					Console.Write(" [ ");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write("Extrato");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine(" ] ");

					Console.SetCursorPosition(1, 2); Console.WriteLine($" > Saldo: {clients[currentLogged, 5]:C2}");
					Console.WriteLine($"{clients[currentLogged, 6]}");
					Console.WriteLine(" ・ Sair" + (menuOpt == 1 ? " <- " : ""));
					currentKey = Console.ReadKey().Key;

					if (currentKey == ConsoleKey.Enter)
					{
						mode = 0;
						break;
					}
				}

				break;

			case 4:
				menuOpt = 1;
				while (true)
				{
					Console.SetCursorPosition(1, 1);
					Console.Write(" [ ");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write("Poupançã");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine(" ] ");

					Console.SetCursorPosition(1, 2); Console.WriteLine($" > Poupança: {clients[currentLogged, 7]:C2}");
					Console.SetCursorPosition(1, 3); Console.WriteLine(" ・ Depositar" + (menuOpt == 1 ? " <- " : ""));
					Console.SetCursorPosition(1, 4); Console.WriteLine(" ・ Sacar    " + (menuOpt == 2 ? " <- " : ""));
					Console.SetCursorPosition(1, 5); Console.WriteLine(" ・ Sair     " + (menuOpt == 3 ? " <- " : ""));
					currentKey = Console.ReadKey().Key;

					if (currentKey == ConsoleKey.UpArrow)
						if (!(menuOpt == 1))
							menuOpt--;

					if (currentKey == ConsoleKey.DownArrow)
						if (!(menuOpt == 3))
							menuOpt++;

					if (currentKey == ConsoleKey.Enter)
					{
						if (menuOpt == 1)
						{
							Console.SetCursorPosition(1, 7); Console.WriteLine(" ・ R$");
							Console.SetCursorPosition(" ・ R$".Length + 1, 7);
							try
							{
								do
								{
									valorASacar = Convert.ToDouble(Console.ReadLine()!);
									if (clients[currentLogged, 5] - valorASacar >= 0)
									{
										clients[currentLogged, 7] += valorASacar;
										clients[currentLogged, 5] -= valorASacar;
										clients[currentLogged, 6] += $" ・ Colocou na poupançã R${valorASacar:C2}\n";
										break;
									}
									else
									{
										Console.SetCursorPosition(1, 6);
										Console.ForegroundColor = ConsoleColor.Red;
										Console.WriteLine($" ・ [Saldo insuficiente] ・ ");
										Console.ForegroundColor = ConsoleColor.White;
										Console.ForegroundColor = ConsoleColor.Black;
										Console.SetCursorPosition(" ・ R$".Length + 1, 7);
										Console.WriteLine(valorASacar);
										Console.SetCursorPosition(" ・ R$".Length + 1, 7);
										Console.ForegroundColor = ConsoleColor.White;
									}
								} while (true);
								
							} catch (Exception ex)
							{
								Console.SetCursorPosition(1, 6);
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine($" ・ [{ex.Message}] ・ ");
								Console.ForegroundColor = ConsoleColor.White;
								Console.ForegroundColor = ConsoleColor.Black;
								Console.SetCursorPosition(" ・ R$".Length + 1, 7);
								Console.WriteLine(valorASacar);
								Console.SetCursorPosition(" ・ R$".Length + 1, 7);
								Console.ForegroundColor = ConsoleColor.White;

							}
						}
						if (menuOpt == 2)
						{
							Console.SetCursorPosition(1, 7); Console.WriteLine(" ・ R$");
							Console.SetCursorPosition(" ・ R$".Length + 1, 7);
							try
							{
								do
								{
									valorASacar = Convert.ToDouble(Console.ReadLine()!);
									if (clients[currentLogged, 5] - valorASacar >= 0)
									{
										clients[currentLogged, 7] -= valorASacar;
										clients[currentLogged, 5] += valorASacar;
										clients[currentLogged, 6] += $" ・ Tirou da poupançã R${valorASacar:C2}\n";
										break;
									}
									else
									{
										Console.SetCursorPosition(1, 6);
										Console.ForegroundColor = ConsoleColor.Red;
										Console.WriteLine($" ・ [Saldo insuficiente] ・ ");
										Console.ForegroundColor = ConsoleColor.White;
										Console.ForegroundColor = ConsoleColor.Black;
										Console.SetCursorPosition(" ・ R$".Length + 1, 7);
										Console.WriteLine(valorASacar);
										Console.SetCursorPosition(" ・ R$".Length + 1, 7);
										Console.ForegroundColor = ConsoleColor.White;
									}
								} while (true);
								
							} catch (Exception ex)
							{
								Console.SetCursorPosition(1, 6);
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine($" ・ [{ex.Message}] ・ ");
								Console.ForegroundColor = ConsoleColor.White;
								Console.ForegroundColor = ConsoleColor.Black;
								Console.SetCursorPosition(" ・ R$".Length + 1, 7);
								Console.WriteLine(valorASacar);
								Console.SetCursorPosition(" ・ R$".Length + 1, 7);
								Console.ForegroundColor = ConsoleColor.White;

							}
						}
						if (menuOpt == 3) break;
					}
					Console.Clear();
				}
				menuOpt = 1;
				mode = 0;
				break;

			case 5:
				menuOpt = 1;
				while (true)
				{
					Console.SetCursorPosition(1, 1);
					Console.Write(" [ ");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write("Empréstimo");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine(" ] ");

					Console.SetCursorPosition(1, 2); Console.WriteLine($" > Saldo: {clients[currentLogged, 5]:C2}");
					Console.SetCursorPosition(1, 3); Console.WriteLine(" ・ Escolher valor" + (menuOpt == 1 ? " <- " : ""));
					Console.SetCursorPosition(1, 4); Console.WriteLine(" ・ Sair          " + (menuOpt == 2 ? " <- " : ""));
					currentKey = Console.ReadKey().Key;

					if (currentKey == ConsoleKey.UpArrow)
						if (!(menuOpt == 1))
							menuOpt--;

					if (currentKey == ConsoleKey.DownArrow)
						if (!(menuOpt == 2))
							menuOpt++;

					if (currentKey == ConsoleKey.Enter)
					{
						if (menuOpt == 1)
						{
							Console.SetCursorPosition(1, 7); Console.WriteLine(" ・ R$");
							Console.SetCursorPosition(" ・ R$".Length + 1, 7);
							try
							{
								do
								{
									valorASacar = Convert.ToDouble(Console.ReadLine()!);
									if (valorASacar <= clients[currentLogged, 5] * 10 )
									{
										clients[currentLogged, 5] += valorASacar;
										clients[currentLogged, 6] += $" ・ Empréstimo de R${valorASacar:C2}\n";
										break;
									}
									else
									{
										Console.SetCursorPosition(1, 6);
										Console.ForegroundColor = ConsoleColor.Red;
										Console.WriteLine($" ・ [Saldo insuficiente] ・ ");
										Console.ForegroundColor = ConsoleColor.White;
										Console.ForegroundColor = ConsoleColor.Black;
										Console.SetCursorPosition(" ・ R$".Length + 1, 7);
										Console.WriteLine(valorASacar);
										Console.SetCursorPosition(" ・ R$".Length + 1, 7);
										Console.ForegroundColor = ConsoleColor.White;
									}
								} while (true);
								
							} catch (Exception ex)
							{
								Console.SetCursorPosition(1, 6);
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine($" ・ [{ex.Message}] ・ ");
								Console.ForegroundColor = ConsoleColor.White;
								Console.ForegroundColor = ConsoleColor.Black;
								Console.SetCursorPosition(" ・ R$".Length + 1, 7);
								Console.WriteLine(valorASacar);
								Console.SetCursorPosition(" ・ R$".Length + 1, 7);
								Console.ForegroundColor = ConsoleColor.White;

							}
						}
						if (menuOpt == 2) break;
					}
					Console.Clear();
				}
				menuOpt = 1;
				mode = 0;
				break;

			case 6:
				currentLogged = 0;
				mode = 0;
				menuOpt = 1;
				break;
		}
		if (currentLogged == 0) break;
	}
	
} while (true);