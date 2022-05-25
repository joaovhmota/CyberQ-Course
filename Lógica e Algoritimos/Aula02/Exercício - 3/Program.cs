double totalVotes = 0;
double c1 = 0;
double c2 = 0;
double c3 = 0;
int input;

do
{
	Console.WriteLine("Escolha um cadidato para votar: ");
	Console.WriteLine("1 - Candidato 1");
	Console.WriteLine("2 - Candidato 2");
	Console.WriteLine("3 - Candidato 3");
	Console.Write(">>> "); input = Convert.ToInt16(Console.ReadLine());

	switch (input)
	{
		case 1:
			c1++;
			totalVotes++;
			break;

		case 2:
			c2++;
			totalVotes++;
			break;

		case 3:
			c3++;
			totalVotes++;

			break;
		default:
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Opção inválida");
			Console.ForegroundColor = ConsoleColor.White;
			break;
	}
} while (input != 0);

Console.Clear();
Console.WriteLine("Total de votos: " + totalVotes);
Console.WriteLine("Candidato 1: {0}% ({1} votos)", c1 / totalVotes * 100, c1);
Console.WriteLine("Candidato 2: {0}% ({1} votos)", c2 / totalVotes * 100, c2);
Console.WriteLine("Candidato 3: {0}% ({1} votos)", c3 / totalVotes * 100, c3);