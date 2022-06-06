string foo(string str)
{
	string returnString = "";
	for (int i = 0; i < str.Length; i++)
	{
		if (i % 2 == 0) returnString += str.ToUpper()[i];
		else returnString += str.ToLower()[i];
	}
	return returnString;
}

Console.WriteLine(foo("Computador"));