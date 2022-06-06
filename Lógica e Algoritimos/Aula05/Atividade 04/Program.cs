const int limit = 30;
string[] cadastrosNome = new string[limit];
DateTime[] cadastrosDate = new DateTime[limit];
int[] birthDaysMonth = new int[12];
string tempName;
string[] dateInput;
int opt;
int mes;
bool isRunning = true;
do
{
	Console.Clear();
	Console.WriteLine("1 - Cadastrar");
	Console.WriteLine("2 - Aniversariante do Mês");
	Console.WriteLine("3 - Procurar Aniversáriante por mês");
	Console.WriteLine("4 - Estatísticas");
	Console.WriteLine("5 - Sair");
	
	opt = Convert.ToInt32(Console.ReadLine()!);

	switch (opt)
	{
		case 1:
			Console.Write("\nDigite o nome: "); tempName = Console.ReadLine()!;
			Console.Write("Digite a data: "); dateInput = Console.ReadLine()!.Replace('-', '/').Split("/");
			for (int i = 0; i < limit; i++)
				if (cadastrosNome[i] == null)
				{
					cadastrosNome[i] = tempName;
					cadastrosDate[i] = new DateTime(
						Convert.ToInt32(dateInput[2]), 
						Convert.ToInt32(dateInput[1]), 
						Convert.ToInt32(dateInput[0])
					);
					break;
				}
			break;
		case 2:
			Console.WriteLine("\nAniversáriantes do Mês:");
			for (int i = 0; i < limit; i++)
			{
				if (cadastrosDate[i].Month == DateTime.Now.Month)
					Console.WriteLine($" - {cadastrosNome[i]} | {cadastrosDate[i].Date}");
			}
			Console.ReadLine();

			break;

		case 3:
			Console.Write("Escolha um mês do ano: "); mes = Convert.ToInt32(Console.ReadLine()!);

			Console.WriteLine($"\nAniversáriantes do Mês {mes}:");
			for (int i = 0; i < limit; i++)
			{
				if (cadastrosDate[i].Month == mes)
					Console.WriteLine($" - {cadastrosNome[i]} | {cadastrosDate[i].Date}");
			}
			Console.ReadLine();

			break;

		case 4:
			birthDaysMonth = new int[12];
			for (int i = 0; i < limit; i++)
				if (cadastrosNome[i] != null)
					birthDaysMonth[cadastrosDate[i].Month - 1]++;

			for (int i = 0; i < 12; i++)
				Console.WriteLine($" No {i+1}° mês, {birthDaysMonth[i]} pessoas fazem aniversário");

			Console.ReadLine();
			break;

		case 5:
			isRunning = false;
			break;
	}
} while (isRunning);