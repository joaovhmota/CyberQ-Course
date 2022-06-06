void foo(string str)
{
	int vogais = 0,
	    consoantes = 0,
	    charSpecial = 0,
	    nums = 0,
	    upper = 0,
	    lower = 0,
	    spaces = 0;

	for (int i = 0; i < str.Length; i++)
	{
		if (Char.IsUpper(str[i])) upper++;
		else if (Char.IsLower(str[i])) lower++;
		else if (Char.IsWhiteSpace(str[i])) spaces++;
		else if (Char.IsPunctuation(str[i])) charSpecial++;
		else if (Char.IsSymbol(str[i])) charSpecial++;
		else if (Char.IsDigit(str[i])) nums++;
		if (str.ToUpper()[i] == 'A' || str.ToUpper()[i] == 'E' || str.ToUpper()[i] == 'I' || str.ToUpper()[i] == 'O' || str.ToUpper()[i] == 'U') vogais++;
		else consoantes++;
	}

	Console.WriteLine($"Vogais: {vogais}");
	Console.WriteLine($"Consoantes: {consoantes - charSpecial}");
	Console.WriteLine($"Letras maísculas: {upper}");
	Console.WriteLine($"Letras minúsculas: {lower}");
	Console.WriteLine($"Total de números: {nums}");
	Console.WriteLine($"Total de caractéres especiais: {charSpecial}");
	Console.WriteLine($"Total de espaços: {spaces}");
}

foo("O rato roeu a roupa do rei de Roma 2022 #####@@@@___");