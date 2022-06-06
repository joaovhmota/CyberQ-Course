Random rnd  = new Random();

int  tempNum = rnd.Next(101),
	input;

string situation = "";

while (true)
{
	Console.WriteLine($"\nSituação: {situation}");
	Console.Write("Chute um número entre 1 e 100: "); input = Convert.ToInt32(Console.ReadLine());

	Console.Clear();

	if (tempNum == input)
	{
		situation = "Acertou!";
		break;
	}
	else if (Math.Abs(input - tempNum) < 10)
		situation = "Perto";

	else if (Math.Abs(input - tempNum) < 20)
		situation = "Longe";

	else 
		situation = "Muito Longe";
}

Console.WriteLine($"\nSituação: {situation}");
Console.Write($"Chute um número entre 1 e 100: {input}\n"); 