int[] ns = new int[10];
int temp;
bool hasN;

for (int i = 0; i < 10; i++)
{
	do
	{
		hasN = false;
		Console.Write($"Write a number: "); temp = Convert.ToInt32(Console.ReadLine()!);

		foreach (int n in ns)
			if (n == temp) hasN = true;

		if (!hasN) 
			ns[i] = temp;

	} while (hasN);
}

foreach(int n in ns)
	Console.WriteLine(n);