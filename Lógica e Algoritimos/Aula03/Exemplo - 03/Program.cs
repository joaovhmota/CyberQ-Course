string[] names = new string[50];
int      index = 0;

while (index < 50)
{
	Console.Write($"Digite o {index + 1}° nome [Slots: {index} / 50]: "); names[index] = Console.ReadLine() ?? "Sem nome";
	Console.WriteLine("Deseja continuar [S/N]?");

	if (Console.ReadLine()!.ToUpper().ToCharArray()[0] == 'N') break;

	Console.Clear();
	index++;
}

for (int i = 0; i < names.Length; i++)
{
	if (names[i] != null)
		Console.WriteLine($"{i+1}° Nome: {names[i]}");
}