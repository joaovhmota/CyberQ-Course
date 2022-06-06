string[] nomes = new string[3];

for (int i = 0; i < nomes.Length; i++)
{
	Console.Write($"Informe o {i+1}° nome: "); nomes[i] = Console.ReadLine()!;
}

foreach (string nome in nomes)
{
	Console.WriteLine(nome);
}