// Matriz
string[,] dados = {
	{"João",     "17", "Brasileiro"},
	{"Henrique", "16", "Brasileiro"},
	{"William",  "21", "Brasileiro"}
};

// Exibir o primeiro nome e idade
for (int i = 0; i < dados.GetLength(0); i++)
	Console.WriteLine($"O {i+1}° usuário é: {dados[i, 0]} e possuí {dados[i, 1]} anos. Ele é {dados[i, 2]}");