string[,] users =
{
	{ "user", "user" },
	{ "admin", "admin" }
};

string login, senha;
bool acessou = false;
int tentativas = 0,
	times = 30;

while (!acessou)
{
	Console.Clear();
	Console.Write("Login: "); login = Console.ReadLine()!;
	Console.Write("Senha: "); senha = Console.ReadLine()!;

	for (int l = 0; l < users.GetLength(0); l++)
	{
		if (users[l, 0] == login && users[l, 1] == senha)
		{
			acessou = true;
			break;
		}
		else
			acessou = false;
	}

	if (!acessou) tentativas++;

	if (tentativas == 3)
	{
		tentativas = 0;
		while (times != 0)
		{
			Console.Clear();
			Console.WriteLine($"Falta {times}s");
			Thread.Sleep(1000);
			times--;
		}
		
	}
}