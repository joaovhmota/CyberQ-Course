Random rnd = new Random();
dynamic[,] scoreTable = new dynamic[100, 2];
string playerName,
	  situation = "";
int playerTries = 0,
    playerGuess = 0,
    correct = 0;
bool isRunning = true,
	acertou = false;

do
{
	Console.Clear();
	Console.Write("\n ・ Digite seu nome, jogador ['Sair' para... obviamente sair]: ");
	playerName = Console.ReadLine()!.ToUpper();
	if (playerName == "SAIR") break;

	Console.Clear();
	correct = rnd.Next(101);
	do
	{
		try
		{
			Console.Clear();

			Console.WriteLine(correct);
			Console.WriteLine((situation != "") ? $" ・ {situation}" : " ・ Gerei um número entre 0 e 100, tente adivinhar.");
			Console.Write(">>> "); playerGuess = Convert.ToInt16(Console.ReadLine()!);

			if (correct == playerGuess) acertou = true;
			else
			{
				playerTries++;
				if (playerGuess > correct + 20 || playerGuess < correct - 20) situation = "Está bem longe...";
				if (playerGuess <= correct + 20 && playerGuess >= correct - 20) situation = "Está longe...";
				if (playerGuess <= correct + 10 && playerGuess >= correct - 10) situation = "Tá perto...";
			}
		} catch (Exception ex) { }
	} while (!acertou);
	Console.Clear();
	Console.WriteLine($" ・ Você, {playerName}, errou {playerTries} vezes até acertar meu número");
	for (int l = 0; l < scoreTable.GetLength(0); l++)
	{
		if (scoreTable[l, 0] == "" || scoreTable[l, 0] == null)
		{
			scoreTable[l, 0] = playerName;
			scoreTable[l, 1] = playerTries;
			break;
		}
	}
	Console.WriteLine(" ・ Sua pontuação foi salva no sistema :).\n ・ Clique [Enter] para continuar");
	playerName = "";
	playerTries = 0;
	playerGuess = -1;
	acertou = false;
	situation = "";
	Console.ReadLine();
} while (isRunning);

Console.Clear();

for (int l = 0; l < scoreTable.GetLength(0); l++)
	for (int c = 0; c < l; c++)
		if (scoreTable[c, 1] > scoreTable[l, 1])
		{
			playerName = scoreTable[c, 0];
			playerTries = scoreTable[c, 1];

			scoreTable[c, l] = scoreTable[c + 1, 1];
			scoreTable[c, 0] = scoreTable[c + 1, 0];

			scoreTable[c + 1, 0] = playerName;
			scoreTable[c + 1, 1] = playerTries;
		}

Console.WriteLine(" ・ Placar:");
for (int l = 0; l < scoreTable.GetLength(0); l++)
	Console.Write( (scoreTable[l, 0] != null ) ? $" ・ {l+1}° {scoreTable[l, 0]} - Tentativas: {scoreTable[l, 1]}\n" : null);