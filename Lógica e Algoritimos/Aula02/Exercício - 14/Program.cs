string nome1    = "",
	  nome2    = "",
	  nome3    = "",
	  tempNome;

bool   running = true;

while (running)
{
	Console.Write("Digite um nome: "); tempNome = Console.ReadLine().ToUpper();
	if (tempNome == null) continue;

	if (nome1.Equals("") && nome2.Equals("") && nome3.Equals(""))
	{
		nome1 = tempNome;
		Console.WriteLine("Primeiro");
	}
	else if (!nome1.Equals("") && nome2.Equals("") && nome3.Equals("") && !tempNome.Equals(nome1))
	{
		nome2 = tempNome;
		Console.WriteLine("Segundo");
	}
	else if (!nome2.Equals("") && !nome1.Equals("") && !tempNome.Equals(nome1) && !tempNome.Equals(nome2))
	{
		nome3 = tempNome;
		Console.WriteLine("Terceiro");
	}

	if (!nome1.Equals("") && !nome2.Equals("") && !nome3.Equals(""))
		running = false;
}

Console.WriteLine($"Nome 1: {nome1}");
Console.WriteLine($"Nome 2: {nome2}");
Console.WriteLine($"Nome 3: {nome3}");