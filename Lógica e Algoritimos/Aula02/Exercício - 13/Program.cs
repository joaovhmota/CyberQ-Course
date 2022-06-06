string nome, maiorNome = "";

int    idade, maiorIdade = 0;

bool   running = true;

while (running)
{
	Console.Clear();
	Console.Write("Coloque um nome de uma pessoa: "); nome = Console.ReadLine();
	Console.Write("Digite a idade dessa pessoa: "); idade = Convert.ToInt32(Console.ReadLine());

	if (idade > maiorIdade)
	{
		maiorNome  = nome;
		maiorIdade = idade;
	}

	Console.Write("[1 - Continuar | 2 - Terminar]: "); running = (Console.ReadLine().ToCharArray()[0] == '2') ? false : true;
}

Console.Clear();
Console.WriteLine($"A pessoa mais velha é o(a) {maiorNome} com {maiorIdade}");