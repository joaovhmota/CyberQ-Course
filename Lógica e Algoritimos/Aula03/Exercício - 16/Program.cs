Random rnd = new Random();
int bombL, bombC;
int shipL, shipC;
int pL, pC;
int bombs = 0,
    tries = 0;
bool hasWon = false,
	botPlay = true,
	isNear = false;

string[,] game = new string[20, 20];
int gameLines = game.GetLength(0);
int gameColumns = game.GetLength(1);

string[,] gameDisplay = new string[gameLines, gameColumns];

for (int l = 0; l < gameLines; l++)
	for (int c = 0; c < gameColumns; c++)
	{
		game[l, c] = "[   ]";
		gameDisplay[l, c] = "[   ]";
	}


// Setar Bombas
for (int nBombs = 0; nBombs < (gameLines * 2); nBombs++)
{
	do
	{
		bombL = rnd.Next(gameLines);
		bombC = rnd.Next(gameColumns);
	} while (game[bombL, bombC] != "[   ]");
	game[bombL, bombC] = "[ B ]";
}

// Setar Navio
shipL = rnd.Next(gameLines); // Linha
shipC = rnd.Next(gameColumns); // Coluna
game[shipL, shipC] = "[ N ]";

// Game
do
{
	// Show Display
	Console.Clear();
	if (!(tries == 0))
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine(　(isNear) ? "\t ・ [Está perto] ・ " : "\t ・ [Está longe] ・ ");
		Console.ForegroundColor = ConsoleColor.White;
	}

	isNear = false;

	Console.Write(" ・ ");
	for (int c = 0; c < gameColumns; c++) Console.Write((c < 10) ?  $"   0{c}" : $"  {c} ");
	Console.WriteLine(" ・ ");

	for (int l = 0; l < gameLines; l++)
	{
		Console.Write((l < 10) ?  $" 0{l} " : $" {l} ");
		for (int c = 0; c < gameColumns; c++)
		{
			if (gameDisplay[l, c] == "[ @ ]")
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write($"{gameDisplay[l, c]}");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else if (gameDisplay[l, c] == "[ § ]")
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write($"{gameDisplay[l, c]}");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else { Console.Write($"{gameDisplay[l, c]}"); }
		}
		Console.Write((l < 10) ?  $" 0{l} " : $" {l} ");
		Console.WriteLine();
	}

	Console.Write(" ・ ");
	for (int c = 0; c < gameColumns; c++) Console.Write((c < 10) ?  $"   0{c}" : $"  {c} ");
	Console.WriteLine(" ・ ");

	// Get Shot Coords
	Console.Write( (!botPlay) ? " ・ Linha: " : null );
	try { pL = (!botPlay) ? Convert.ToInt16(Console.ReadLine()!) : rnd.Next(gameLines); } catch (Exception ex) { continue; }

	Console.Write( (!botPlay) ? " ・ Coluna: " : null );
	try { pC = (!botPlay) ? Convert.ToInt16(Console.ReadLine()!) : rnd.Next(gameColumns); } catch (Exception ex) { continue; }

	if (gameDisplay[pL, pC] == "[ @ ]" || gameDisplay[pL, pC] == "[ ¤ ]") continue;

	// Verify Shot
	if (game[pL, pC] == "[ N ]")
	{
		gameDisplay[pL, pC] = "[ § ]";
		hasWon = true;
	}
	else if (game[pL, pC] == "[ B ]")
	{
		gameDisplay[pL, pC] = "[ @ ]";
		bombs++;
	}
	else
	{
		gameDisplay[pL, pC] = "[ ¤ ]";
		for (int l = -1; l < 2; l++)
		{
			for (int c = -1; c < 2; c++)
			{
				try
				{
					if (game[pL + l, pC + c] == "[ B ]" || game[pL + l, pC + c] == "[ N ]") isNear = true;
				}
				catch (Exception ex) {};
			}
		}
	}

	Thread.Sleep( (botPlay) ? 1 : 1);
	tries++;
} while (!hasWon && !(bombs == gameLines));

// Show Result Display
Console.Clear();
Console.Write(" ・ ");
for (int c = 0; c < gameColumns; c++) Console.Write((c < 10) ?  $"   0{c}" : $"  {c} ");
Console.WriteLine(" ・ ");

for (int l = 0; l < gameLines; l++)
{
	Console.Write((l < 10) ?  $" 0{l} " : $" {l} ");
	for (int c = 0; c < gameColumns; c++)
	{
		if (gameDisplay[l, c] == "[ @ ]")
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write($"{gameDisplay[l, c]}");
			Console.ForegroundColor = ConsoleColor.White;
		}
		else if (gameDisplay[l, c] == "[ § ]")
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write($"{gameDisplay[l, c]}");
			Console.ForegroundColor = ConsoleColor.White;
		}
		else { Console.Write($"{gameDisplay[l, c]}"); }
	}
	Console.Write((l < 10) ?  $" 0{l} " : $" {l} ");
	Console.WriteLine();
}

Console.Write(" ・ ");
for (int c = 0; c < gameColumns; c++) Console.Write((c < 10) ?  $"   0{c}" : $"  {c} ");
Console.WriteLine(" ・ ");

if (hasWon)
{
	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine("\t ・ [Jogador Venceu] ・ ");
	Console.ForegroundColor = ConsoleColor.White;
}
else
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("\t ・ [Jogador Perdeu] ・ ");
	Console.ForegroundColor = ConsoleColor.White;
}