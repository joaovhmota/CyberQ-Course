int[] ns = new int[10];

for (int i = 0; i < ns.Length; i++)
{
	Console.Write("Type a number: "); ns[i] = Convert.ToInt32(Console.ReadLine()!);
}

Array.Sort(ns);

Console.Write($"[ ");
foreach (int n in ns)
	Console.Write($"{n} ");
Console.WriteLine("]");

Console.WriteLine($"Sum: {ns.Sum()}");
Console.WriteLine($"Avarage: {ns.Sum() / ns.Length}");

foreach (int n in ns) 
	if (n > (ns.Sum() / ns.Length)) 
		Console.WriteLine($"{n} is above the avarage");