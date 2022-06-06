string[] names = new string[100];
int index = 0;

do
{
	Console.Write($"Write a name to add [{index} / {names.Length}]: ");
	names[index] = Console.ReadLine()!;
	index++;

	Console.WriteLine("Continue? [Y/N]: ");
	if (Console.ReadLine()?.ToUpper().ToCharArray()[0] == 'N') break;
	else continue;
} while (true);

for (int i = 0; i < names.Length; i++)
{
	Console.Write( (names[i] == null) ? null : $"Name: {names[i]}" );
}