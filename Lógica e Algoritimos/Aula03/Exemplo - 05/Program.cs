string[,] matriz = new string[3, 2];

for (int i = 0; i < matriz.GetLength(0); i++)
{
	Console.Write($"Informe o {i+1}° nome: ");
	matriz[i, 0] = Console.ReadLine()!;
	
	Console.Write($"Informe a idade de {matriz[i, 0]}: ");
	matriz[i, 1] = Console.ReadLine()!;
}

for (int i = 0; i < matriz.Length / 2; i++)
{
	Console.WriteLine($"{matriz[i, 0]} têm {matriz[i, 1]} anos");
}