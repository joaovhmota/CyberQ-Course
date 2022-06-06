string[] names = new string[5];
string tempName;
bool hasName;

for (int i = 0; i < names.Length; i++)
{
	do
	{
		hasName = false;
		Console.WriteLine("Type a name: ");
		tempName = Console.ReadLine()!;
		foreach (string name in names)
			if (name == tempName) hasName = true;

	} while (hasName);
	names[i] = tempName;
}

Console.Clear();
foreach (string nome in names)
{
	Console.WriteLine(nome);
	Thread.Sleep(200);
}