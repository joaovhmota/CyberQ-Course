string[,] cadastro = new string[5, 3];
string tempNome;

for (int l = 0; l < cadastro.GetLength(0); l++)
{
	Console.Write("Digite um nome: "); tempNome = Console.ReadLine()!;
	if (tempNome == "" || tempNome == null) tempNome = "<Unknown>";

	cadastro[l, 0] = tempNome;
	cadastro[l, 2] = DateTime.Now.ToString("HH:m:s");
	cadastro[l, 1] = DateTime.Now.ToString("dd/MM/yyyy");
}

for (int l = 0; l < cadastro.GetLength(0); l++)
	Console.WriteLine($"{cadastro[l, 0]} - {cadastro[l, 1]} {cadastro[l, 2]}");