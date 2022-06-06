dynamic[,] students = new dynamic[100, 5]; // Nome, n1, n2, média, situação

int totalCadastrados = 0,
    aprovados       = 0,
    reprovados      = 0;

string nomeEstudante;

double nota1,
	  nota2,
	  mediaGeral = 0;

string maiorNome = "";

double maiorNota1 = 0,
	  maiorNota2 = 0,
	  maiorMedia = 0;

string comBola(string str = "") => (str == "" || str == null) ? null : $" ・ {str}";

do
{
	try
	{
		Console.Clear();
		Console.Write(comBola("Digite o nome do aluno [0 para sair]: "));
		nomeEstudante = Console.ReadLine()!;
		if (nomeEstudante == "0") break;
		
		Console.Write(comBola("Digite a primeira nota do aluno: "));
		nota1 = Convert.ToDouble(Console.ReadLine()!);

		Console.Write(comBola("Digite a segunda nota do aluno: "));
		nota2 = Convert.ToDouble(Console.ReadLine()!);

		for (int l = 0; l < students.GetLength(0); l++)
		{
			if (students[l, 0] == null)
			{
				students[l, 0] = nomeEstudante;
				students[l, 1] = nota1;
				students[l, 2] = nota2;
				students[l, 3] = (nota1 + nota2) / 2;
				mediaGeral += (nota1 + nota2) / 2;
				totalCadastrados++;

				if (students[l, 4] > maiorMedia)
				{
					maiorNome = students[l, 0];
					maiorNota1 = students[l, 1];
					maiorNota2 = students[l, 2];
					maiorMedia = students[l, 3];
				}
				break;
			}
		}
	} catch (Exception ex) { }
} while (true);

for (int l = 0; l < students.GetLength(0); l++)
{
	if (students[l, 3] >= 7)
	{
		students[l, 4] = "Aprovado";
		aprovados++;
	}
	else
	{
		students[l, 4] = "Reprovado";
		reprovados--;
	}
}

Console.WriteLine(comBola("Resultado: "));
Console.WriteLine(comBola($"Total cadastrados: {totalCadastrados}"));
Console.WriteLine(comBola($"Total de aprovados: {aprovados}"));
Console.WriteLine(comBola($"Total de reprovados: {reprovados + 100}"));
Console.WriteLine(comBola($"Melhor aluno: {maiorNome} (Nota 1: {maiorNota1} | Nota 2: {maiorNota2} | Média: {maiorMedia})"));
Console.WriteLine(comBola("Todos os alunos: "));
for (int l = 0; l < students.GetLength(0); l++)
{
	Console.Write(comBola(comBola( (students[l, 0] != null) ? $"Nome: {students[l, 0]} | Média: {students[l, 3]} | Situação: {students[l, 4]}\n" : null)));
}