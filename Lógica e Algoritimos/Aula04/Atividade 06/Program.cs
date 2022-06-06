bool verifyEmail(string email = "")
{
	char[] noSymbols = { '\'', '"', '!', '¹', '²', '#', '³', '$', '£', '%', '¢', '¨', '¬', '&', '*', '(', ')', '+', '=', '§', '´', '`', '[', '{', 'ª', '^', '~', ']', '}', 'º', '\\', '|', ',', '<', '>', ';', ':', '/', '?', '°'};

	if (email.ToUpper() == email) return false;

	for (int i = 0; i < noSymbols.Length; i++)
		if (email.Contains(noSymbols[i])) return false;

	string[] splitEmail = email.Split("@");

	if (splitEmail.Length == 2) 
		if (splitEmail[1].Split(".")[0].Length >= 5) 
			if (splitEmail[1].Split(".").Length >= 2) 
				return true;
	return false;
}

string emailBemBaita = Console.ReadLine()!;

Console.WriteLine(verifyEmail(emailBemBaita));