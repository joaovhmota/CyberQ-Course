int[] ns = new int[5];

int size         = ns.Length - 1,
    changes      = 0,
    aux;


for (int i = 0; i < ns.Length; i++)
{
	Console.Write("Type a number: "); ns[i] = Convert.ToInt32(Console.ReadLine()!);
}


for (int i = size; i >= 1; i--)
{
	for (int j = 0; j < i; j++)
	{
		if (ns[j] > ns[j + 1])
		{
			aux = ns[j];
			ns[j] = ns[j + 1];
			ns[j + 1] = aux;
			changes++;
		}
	}
}

foreach (int n in ns)
	Console.WriteLine(n);