bool isPalindromo(string str)
{
	str = str.ToLower();
	string reverseString = "";
	for (int i = str.Length - 1; i >= 0; i--)
	{
		reverseString += str[i];
	}
	if (str == reverseString)
		return true;
	else
		return false;
}

Console.WriteLine(isPalindromo("arroz"));
Console.WriteLine(isPalindromo("ama"));