int[] ns = new int[5];

for (int i = 0; i < ns.Length; i++)
{
	Console.Write("Insira um número: "); ns[i] = Convert.ToInt32(Console.ReadLine()!);
}
Console.Clear();
for (int i = ns.Length - 1; i >= 0; i--)
	Console.WriteLine(ns[i]);