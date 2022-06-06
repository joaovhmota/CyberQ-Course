int[] ns = new int[5];
bool found10 = false;

for (int i = 0; i < ns.Length; i++)
{
	Console.Write("Type a number: "); ns[i] = Convert.ToInt32(Console.ReadLine()!);
}

for (int i = 0; i < ns.Length; i++)
{
	if (ns[i] == 10)
	{
		Console.WriteLine($"The number 10 was found in the {i} position of th array");
		found10 = true;
	}
}

if (!found10)
	Console.WriteLine("The number 10 was not found in the array");