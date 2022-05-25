byte lifes = 7;
bool hasE      = false,
	hasS      = false,
	hasT      = false,
	hasU      = false,
	hasD      = false,
	hasA      = false,
	hasR      = false,
	won       = false,
	hasLetter = false;
char letter;
string usedLetters = " ";

while (lifes != 0)
{
	Console.Clear();
	if (hasA && hasD && hasE && hasR && hasS && hasT && hasU) won = true;
	if (won) break;

	Console.Write("\tVidas: ");
	Console.ForegroundColor = ConsoleColor.Cyan;
	Console.Write(lifes + "\n");
	Console.ForegroundColor = ConsoleColor.White;

	Console.WriteLine("\tPALAVRA: " + 
		(!hasE ? "_" : "E") +
		(!hasS ? "_" : "S") +
		(!hasT ? "_" : "T") +
		(!hasU ? "_" : "U") +
		(!hasD ? "_" : "D") +
		(!hasA ? "_" : "A") +
		(!hasR ? "_" : "R"));
	Console.WriteLine("\tLetras já usadas:" + usedLetters);

	Console.Write("\tFale uma letra: "); letter = Console.ReadLine().ToUpper().ToCharArray()[0];

	switch (letter)
	{
		case 'E':
			hasE = true;
			break;

		case 'S':
			hasS = true;
			break;

		case 'T':
			hasT = true;
			break;

		case 'U':
			hasU = true;
			break;

		case 'D':
			hasD = true;
			break;

		case 'A':
			hasA = true;
			break;

		case 'R':
			hasR = true;
			break;

		default:
			lifes--;
			break;
	}
	foreach (char usada in usedLetters.ToCharArray())
		if (usada == letter) hasLetter = true;

	if (!hasLetter) usedLetters += letter + " ";
}

Console.Clear();
Console.WriteLine($"\tVidas: {lifes}");
Console.WriteLine("\tPALAVRA: " + 
	(!hasE ? "_" : "E") +
	(!hasS ? "_" : "S") +
	(!hasT ? "_" : "T") +
	(!hasU ? "_" : "U") +
	(!hasD ? "_" : "D") +
	(!hasA ? "_" : "A") +
	(!hasR ? "_" : "R"));
Console.WriteLine("\tLetras já usadas:" + usedLetters);

if (!won)
{
	Console.Write("\n\tVocê ");
	Console.ForegroundColor = ConsoleColor.Red;
	Console.Write("PERDEU");
	Console.ForegroundColor = ConsoleColor.White;
	Console.Write("! A palavra era: ");
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.Write("ESTUDAR\n");
	Console.ForegroundColor = ConsoleColor.White;
}
else
{
	Console.Write("\n\tVocê ");
	Console.ForegroundColor = ConsoleColor.Green;
	Console.Write("GANHOU");
	Console.ForegroundColor = ConsoleColor.White;
	Console.Write("!\n");
}
