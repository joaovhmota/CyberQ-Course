dynamic[,] colors = {
	{ "", 0 },
	{ "", 0 },
	{ "", 0 },
	{ "", 0 },
	{ "", 0 },
	{ "", 0 },
	{ "", 0 },
	{ "", 0 },
	{ "", 0 },
	{ "", 0 },
};
string tempColor;
bool hasColor;

for (int a = 0; a < colors.Length / 2; a++)
{
	hasColor = false;

	Console.Write("Type a color: ");
	tempColor = Console.ReadLine()!;

	for (int b = 0; b < colors.Length / 2; b++)
	{
		if (colors[b, 0] == tempColor)
		{
			colors[b, 1]++;
			hasColor = true;
		}
		else if (colors[b, 0] == "" && !hasColor)
		{
			colors[b, 0] = tempColor;
			colors[b, 1]++;
			break;
		}
	}
}

for (int i = 0; i < colors.Length / 2; i++)
	if (colors[i, 0] != "") Console.WriteLine($"{colors[i, 0]}: {colors[i, 1]}");