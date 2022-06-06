char[,] words =
{
	{ 'A', 'B', 'E', 'L', 'H', 'A', '#' },
	{ 'B', 'A', 'T', 'A', 'T', 'A', '#' },
	{ 'T', 'I', 'J', 'O', 'L', 'O', '#' },
	{ 'D', 'U', 'V', 'I', 'D', 'A', '#' },
	{ 'B', 'O', 'T', 'I', 'J', 'A', 'O' },
	{ 'R', 'O', 'T', 'I', 'N', 'A', '#' },
	{ 'R', 'E', 'Z', 'A', 'R', '#', '#' },
	{ 'P', 'R', 'A', 'I', 'A', '#', '#' },
	{ 'V', 'E', 'N', 'E', 'N', 'O', '#' },
	{ 'M', 'O', 'C', 'H', 'I', 'L', 'A' },
	{ 'C', 'A', 'V', 'A', 'L', 'O', '#' }
};

int matrizLines = words.GetLength(0);
int matrizColumns = words.GetLength(1);

int[] gabarito = new int[matrizColumns];
for (int i = 0; i < matrizColumns; i++) gabarito[i] = 0;

Random random = new Random();
int linha = random.Next(matrizLines),
    acertos = 0;
char guess = ' ';

do
{
	// Print da palavra e marcação de pontos
	Console.Write("Palavra: ");
	for (int i = 0; i < matrizColumns; i++)
	{
		if (gabarito[i] == 1)
		{
			Console.Write(words[linha, i]);
			acertos++;
		}
		else if (words[linha, i] == '#')
		{
			Console.Write("");
			acertos++;
		}
		else Console.Write("_");
	}
	Console.WriteLine();

	if (acertos == matrizColumns) break;

	// Pega a letra
	Console.Write("Escolha uma letra: "); guess = Console.ReadLine()!.ToUpper().ToCharArray()[0];

	// Verifica resposta
	for (int i = 0; i < matrizColumns; i++)
		if (words[linha, i] == guess)
			gabarito[i] = 1;

	acertos = 0;

	Console.Clear();
} while (true);