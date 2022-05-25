int input;

Console.Write("Informe um número: "); input = Convert.ToInt32(Console.ReadLine());

for (int i = input - 10; i <= input + 10; i++)
{
	Console.Write(i + " ");
}