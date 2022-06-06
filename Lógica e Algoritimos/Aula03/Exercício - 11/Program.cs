/*
 * [] [] []
 * [] [] []
 * [] [] []
*/
string[,] jogo =
{
	{ " ", " ", " " },
	{ " ", " ", " " },
	{ " ", " ", " " }
};
bool hasFinished = false,
	velha = false;
string currentPlayer = "O";
int[] opt = { 0, 0 };
int cases = 0;

do
{
	currentPlayer = (currentPlayer == "X" && !hasFinished) ? "O" : "X";
	Console.Clear();
	Console.WriteLine($"Vez de: [{currentPlayer}]");
	Console.WriteLine("\t  0 1 2");
	Console.WriteLine($"\t0 {jogo[0, 0]}|{jogo[0, 1]}|{jogo[0, 2]}");
	Console.WriteLine("\t  -----");
	Console.WriteLine($"\t1 {jogo[1, 0]}|{jogo[1, 1]}|{jogo[1, 2]}");
	Console.WriteLine("\t  -----");
	Console.WriteLine($"\t2 {jogo[2, 0]}|{jogo[2, 1]}|{jogo[2, 2]}");

	Console.Write("Posição 1: "); opt[0] = Convert.ToInt16(Console.ReadLine()); 
	Console.Write("Posição 2: "); opt[1] = Convert.ToInt16(Console.ReadLine());

	if (jogo[opt[0], opt[1]] != " ") continue;

	jogo[opt[0], opt[1]] = currentPlayer;


	// Linhas
	if (jogo[0,0] != " " && jogo[0, 0] == jogo[0, 1] && jogo[0, 1] == jogo[0, 2])
		hasFinished = true;
	if (jogo[1,0] != " " && jogo[1, 0] == jogo[1, 1] && jogo[1, 1] == jogo[1, 2])
		hasFinished = true;
	if (jogo[2,0] != " " && jogo[2, 0] == jogo[2, 1] && jogo[2, 1] == jogo[2, 2])
		hasFinished = true;

	// Colunas
	if (jogo[0, 0] != " " && jogo[0, 0] == jogo[1, 0] && jogo[1, 0] == jogo[2, 0])
		hasFinished = true;
	if (jogo[0, 1] != " " && jogo[0, 1] == jogo[1, 1] && jogo[1, 1] == jogo[2, 1])
		hasFinished = true;
	if (jogo[0, 2] != " " && jogo[0, 2] == jogo[1, 2] && jogo[1, 2] == jogo[2, 2])
		hasFinished = true;

	// Diagonal
	if (jogo[0, 0] != " " && jogo[0, 0] == jogo[1, 1] && jogo[1, 1] == jogo[2, 2])
		hasFinished = true;
	if (jogo[0, 2] != " " && jogo[0, 2] == jogo[1, 1] && jogo[1, 1] == jogo[2, 0])
		hasFinished = true;

	cases++;

	// Velha
	if (cases == 9 && !hasFinished)
	{
		velha = true;
		hasFinished = true;
	}

	Console.Clear();
} while (!hasFinished);

Console.WriteLine( (velha) ? $"Deu velha" : $"{currentPlayer} Ganhou" );
Console.WriteLine("\t  0 1 2");
Console.WriteLine($"\t0 {jogo[0, 0]}|{jogo[0, 1]}|{jogo[0, 2]}");
Console.WriteLine("\t  -----");
Console.WriteLine($"\t1 {jogo[1, 0]}|{jogo[1, 1]}|{jogo[1, 2]}");
Console.WriteLine("\t  -----");
Console.WriteLine($"\t2 {jogo[2, 0]}|{jogo[2, 1]}|{jogo[2, 2]}");