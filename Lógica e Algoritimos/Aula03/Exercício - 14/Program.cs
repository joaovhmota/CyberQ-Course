/*
 * [] [] []
 * [] [] []
 * [] [] []
*/
Random pc = new Random();
string[,] game =
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
	Console.WriteLine($"\t0 {game[0, 0]}|{game[0, 1]}|{game[0, 2]}");
	Console.WriteLine("\t  -----");
	Console.WriteLine($"\t1 {game[1, 0]}|{game[1, 1]}|{game[1, 2]}");
	Console.WriteLine("\t  -----");
	Console.WriteLine($"\t2 {game[2, 0]}|{game[2, 1]}|{game[2, 2]}");

	if (currentPlayer == "X")
	{ 
		/*
		Console.Write("Posição 1: "); 
		opt[0] = Convert.ToInt16(Console.ReadLine()); 
		Console.Write("Posição 2: "); 
		opt[1] = Convert.ToInt16(Console.ReadLine());
		*/
		opt[0] = pc.Next(3);
		opt[1] = pc.Next(3);
	}
	else
	{
		opt[0] = pc.Next(3);
		opt[1] = pc.Next(3);
	}


	if (game[opt[0], opt[1]] != " ")
	{
		currentPlayer = (currentPlayer == "X" && !hasFinished) ? "O" : "X";
		continue;
	}

	game[opt[0], opt[1]] = currentPlayer;

	// Linhas
	if (game[0,0] != " " && game[0, 0] == game[0, 1] && game[0, 1] == game[0, 2])
		hasFinished = true;
	if (game[1,0] != " " && game[1, 0] == game[1, 1] && game[1, 1] == game[1, 2])
		hasFinished = true;
	if (game[2,0] != " " && game[2, 0] == game[2, 1] && game[2, 1] == game[2, 2])
		hasFinished = true;

	// Colunas
	if (game[0, 0] != " " && game[0, 0] == game[1, 0] && game[1, 0] == game[2, 0])
		hasFinished = true;
	if (game[0, 1] != " " && game[0, 1] == game[1, 1] && game[1, 1] == game[2, 1])
		hasFinished = true;
	if (game[0, 2] != " " && game[0, 2] == game[1, 2] && game[1, 2] == game[2, 2])
		hasFinished = true;

	// Diagonal
	if (game[0, 0] != " " && game[0, 0] == game[1, 1] && game[1, 1] == game[2, 2])
		hasFinished = true;
	if (game[0, 2] != " " && game[0, 2] == game[1, 1] && game[1, 1] == game[2, 0])
		hasFinished = true;

	cases++;

	// Velha
	if (cases == 9 && !hasFinished)
	{
		velha = true;
		hasFinished = true;
	}

	Thread.Sleep(200);
	Console.Clear();
} while (!hasFinished);

Console.WriteLine( (velha) ? $"Deu velha" : $"{currentPlayer} Ganhou" );
Console.WriteLine("\t  0 1 2");
Console.WriteLine($"\t0 {game[0, 0]}|{game[0, 1]}|{game[0, 2]}");
Console.WriteLine("\t  -----");
Console.WriteLine($"\t1 {game[1, 0]}|{game[1, 1]}|{game[1, 2]}");
Console.WriteLine("\t  -----");
Console.WriteLine($"\t2 {game[2, 0]}|{game[2, 1]}|{game[2, 2]}");