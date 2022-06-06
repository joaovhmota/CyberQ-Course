int[,] matriz = {
	{ 1, 2, 3, 4, 5 },
	{ 1, 2, 3, 4, 5 },
	{ 1, 2, 3, 4, 5 },
	{ 1, 2, 3, 4, 5 },
	{ 1, 2, 3, 4, 5 },
};
int avarage = 0,
    sum = 0;

int[] dPrimary = new int[5];
int[] dSecondary = new int[5];

for (int l = 0; l < 5; l++)
{
	Console.Write("\t{ ");
	for (int c = 0; c < 5; c++)
	{
		sum += matriz[l, c];
		Console.Write($"{matriz[l, c]} ");
	}
	Console.WriteLine("} ");
}
Console.WriteLine("");

dPrimary = new int[5] { matriz[0, 0], matriz[1, 1], matriz[2, 2], matriz[3, 3], matriz[4, 4] };
dSecondary = new int[5] { matriz[4, 0], matriz[3, 1], matriz[2, 2], matriz[1, 3], matriz[0, 4] };

avarage = sum / matriz.Length;

Console.WriteLine($"A soma dos valores na matriz é: {sum}");
Console.WriteLine($"A média dos valores na matriz é: {avarage}");

Console.WriteLine($"Diagonal principal: ");
foreach (int n in dPrimary)
	Console.Write($"{n} ");
Console.WriteLine();

Console.WriteLine($"Diagonal secundária: ");
foreach (int n in dSecondary)
	Console.Write($"{n} ");
Console.WriteLine();

Console.Write("Acima da média: ");
for (int l = 0; l < 5; l++)
	for (int c = 0; c < 5; c++)
		if (matriz[l, c] >= avarage) Console.Write($"{matriz[l, c]} ");		