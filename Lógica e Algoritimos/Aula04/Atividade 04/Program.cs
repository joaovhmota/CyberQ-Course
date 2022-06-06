// Matriz com nome e quantidade
string[,] names    =  new string[100, 2];
string    tempName = "";

bool run = true;

// Cadastrando novos nomes
while(run)
{
	Console.Clear();
	Console.Write("Digite um nome \n>>>> ");
    tempName = Console.ReadLine();
	for (int i = 0; i < names.GetLength(0); i++)
	{
		if (names[i, 0] == tempName)
		{
			names[i, 1] = Convert.ToString(Convert.ToInt32(names[i, 1])+1);
			break;
		}
		else
		{
			names[i, 0] = tempName;
			names[i, 1] = "1";
			break;
		}
	}
	Console.Clear();
	Console.Write("Adicionar outro nome? \n01) Sim \n02) Não \n>>>> ");
    try
    {
		run = (Convert.ToInt32(Console.ReadLine()) == 1) ? true : false;
	} catch (Exception ex) { };
}
// Mostrando os nomes cadastrados
Console.Clear();
for (int i = 0; i < names.GetLength(0); i++)
{
    if(names[i, 0] != null && names[i, 0] != "")
        Console.WriteLine($"Nome: {names[i, 0]}, quantidade cadastrada: {names[i, 1]}");
}