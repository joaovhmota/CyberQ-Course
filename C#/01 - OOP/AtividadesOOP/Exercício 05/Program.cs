using Exercício_05;

CeaserCypher cypher = new CeaserCypher();

string str = "",
	  opt = "";

int key = 0;

do
{
	try
	{
		Console.Clear();
		Console.WriteLine(" ・ 1 - Criptografar");
		Console.WriteLine(" ・ 2 - Descriptografar");
		Console.WriteLine(" ・ 3 - Finalizar");
		opt = Console.ReadLine()!;
		if (opt == "3") break;

		Console.Write(" ・ Digite uma frase para criptografar: "); str = Console.ReadLine()!;
		if (str == "") continue;

		Console.Write(" ・ Digite uma chave para criptografia: "); key = Convert.ToInt32(Console.ReadLine()!);

		switch (opt)
		{
			case "1": Console.WriteLine($" ・ Resultado: {cypher.Update(str).Encrypt(key)}"); break;
			case "2": Console.WriteLine($" ・ Resultado: {cypher.Update(str).Decrypt(key)}"); break;
		}
	}
	catch (Exception ex) { continue; }
} while (true);