string[,] questions = {
    {"Qual a capital de Santa Catarina?",                      "Blumenau",         "Florianópolis",         "Joinville",        "Florianópolis"},
    {"Nome dado ao conjunto de ossos?",                        "Grayskull",        "Ossada",                "Esqueleto",        "Esqueleto"},
    {"Quanto é: 2 X 4 + 8?",                                   "18",               "16",                    "24",               "16"},
    {"Capital do estado do Paraná?",                           "Curitiba",         "Londrina",              "Maringá",          "Curitiba"},
    {"Qual a capital da Turquia?",                             "Istambul",         "Ancara",                "Esmirna",          "Ancara"},
    {"Cidade onde concentra o maior número de pessoas",        "Tóquio",           "Nova Iorque",           "Pequim",           "Tóquio"},
    {"Qual o idioma mais falado no mundo?",                    "Inglês",           "Mandarim",              "Espanhol",         "Inglês"},
    {"O que é uma pessoa chitosa?",                            "Rude",             "Brincalhona",           "Raivosa",          "Brincalhona"},
    {"O que é Eflúvio",                                        "Um som",           "Um sabor",              "Um aroma",         "Um aroma"},
    {"O que é uma pessoa loquaz?",                             "Fala muito",       "Fala pouco",            "Gaga",             "Fala muito"},
    {"Quando ocorreu a segunda guerra mundial?",               "1939 - 1944",      "1938 - 1944",           "1940 - 1944",      "1939 - 1944"},
    {"De onde é a invenção do chuveiro elétrico?",             "França",           "Brasil",                "Inglaterra",       "Brasil"},
    {"Qual o menor país do mundo?",                           "Vaticano",         "Nauru",                 "Mônaco",           "Vaticano"},
    {"Qual o maior país do mundo?",                           "China",            "Rússia",                "Canadá",           "Rússia"},
    {"Após a Bíblia, qual é o livro mais vendido?",            "Dom Quixote",      "O Pequeno Príncipe",    "Senhor dos anéis", "Dom Quixote"},
    {"Quantos elementos possui a tabela periódica?",           "113",              "109",                   "118",              "118"},
    {"País com a maior expectativa de vida do mundo",          "Austrália",        "Japão",                 "Suécia",           "Japão"},
    {"Quanto tempo a luz do Sol demora para chegar à Terra?",  "12 minutos",       "3 minutos",             "8 minutos",        "8 minutos"},
    {"Qual a montanha mais alta do Brasil?",                   "Pico da Bandeira", "Pico Paraná",           "Pico da Neblina",  "Pico da Neblina"},
    {"Em qual local da Ásia o português é língua oficial?",    "Índia",            "Moçambique",            "Macau",            "Macau"},
    {"Qual destes países é transcontinental?",                 "Rússia",           "Estados Unidos",        "Marrocos",         "Rússia"},
    {"Qual o maior animal terrestre?",                         "Baleia Azul",      "Elefante africano",     "Girafa",           "Elefante africano"},
    {"Com que dois países faz fronteira o Equador?",           "Brasil e Colômbia","Colômbia e Venezuela",  "Colômbia e Peru",  "Colômbia e Peru"},
    {"Que animal gruguleja?",                                  "Pavão",            "Peru",                  "Garça",            "Garça"},
    {"Qual é o maior arquipélago da Terra?",                   "Filipinas",        "Indonésia",             "Maldivas",         "Indonésia"},
    {"Em que oceano fica Madagascar?",                         "Oceano Índico",    "Oceano Atlântico",      "Oceano Pacífico",  "Oceano Índico"},
    {"Qual o metal cujo símbolo químico é o Au?",              "Cobre",            "Ouro",                  "Prata",            "Ouro"},
    {"Quem pintou o teto da capela sistina?",                  "Michelangelo",     "Leonardo da Vinci",     "Donatello",        "Michelangelo"},
    {"O que é filantropo?",                                    "Pessoa egoísta",   "Pessoa caridosa",       "Um poema",         "Pessoa caridosa"},
    {"Qual a população do Brasil?",                            "220 milhões",      "200 milhões",           "212 milhões",      "212 milhões"}
};

Random rnd = new Random();
string[,] playerStats = new string[100, 2]; // Nome, Pontuação
int[] shownQuestions = new int[10]; // Questões já mostradas
int acertos = 0,
    erros = 0,
    removerErros = 0,
    pulos = 0,
    quantShowQuestions = 0,
    currentQuestion = 0,
    	usouAjuda = 0;
bool isPlaying = true,
	hasName = false,
	hasQuestion = false;

string currentName;

int playerGuess = 0;
string playAgain = "";

while (isPlaying)
{
	Console.Clear();

	quantShowQuestions = 0;
	acertos = 0;
	shownQuestions = new int[10];
	usouAjuda = 0;
	pulos = 0;

	do
	{
		Console.Clear();
		hasName = false;
		Console.Write(" ・ Digite o seu nome, Jogador: "); currentName = Console.ReadLine()!.ToUpper();
		for (int l = 0; l < playerStats.GetLength(0); l++)
		{
			if (playerStats[l, 0] == currentName)
			{
				hasName = true;
				break;
			}
		}
	} while (hasName);
	
	while (quantShowQuestions != 10)
	{
		// Gera a questão
		do
		{
			hasQuestion = false;
			if (pulos > 3)
				break;
			if (usouAjuda == 1)
			{
				break;
			}
			currentQuestion = rnd.Next(questions.GetLength(0));
			for (int i = 0; i < shownQuestions.Length; i++)
			{
				if (shownQuestions[i] == currentQuestion) hasQuestion = true;
			}
		} while (hasQuestion);

		// Faz a questão
		playerGuess = -1;
		do
		{
			try
			{
				Console.Clear();
				Console.WriteLine($"\n {quantShowQuestions + 1}° {questions[currentQuestion, 0]}");
				Console.Write( (usouAjuda != 1) ? $" ・ 1 - {questions[currentQuestion, 1]}                     \n" : null );
				Console.Write( (usouAjuda != 1) ? $" ・ 2 - {questions[currentQuestion, 2]}                     \n" : null );
				Console.Write( (usouAjuda != 1) ? $" ・ 3 - {questions[currentQuestion, 3]}                     \n" : null );
				Console.Write( (usouAjuda == 1) ? $" ・ 1 - {questions[currentQuestion, 4]}                     \n" : null );
				Console.Write( (usouAjuda == 0) ? $" ・ 4 - Elimitar Alterativa(s)\n" : null);
				Console.Write((usouAjuda != 1) ? $" ・ 5 - Pular Questão\n" : null);
				
				Console.Write(" ・ >>> "); playerGuess = Convert.ToInt16(Console.ReadLine());
				if (usouAjuda != 1 && playerGuess <= 5 && playerGuess >= 1) break;
				if (usouAjuda == 1 && playerGuess == 1) break;
			} catch (Exception ex) { }
		} while (true);

		// Ajuda remover erros
		if (playerGuess == 4 && usouAjuda == 0)
		{
			removerErros = rnd.Next(3);
			usouAjuda++;
			continue;
		}

		if (usouAjuda == 1)
		{
			acertos++;
			usouAjuda++;
			quantShowQuestions++;
		}
		// Verifica a resposta
		else if (playerGuess >= 1 && playerGuess <= 3)
		{
			if ((questions[currentQuestion, playerGuess] == questions[currentQuestion, 4]))
				acertos++;
			
			quantShowQuestions++;
		}
		// Ajuda Pular questão
		if (playerGuess == 5)
		{
			pulos++;
		}


		// Add a questão a lista de vistos
		for (int i = 0; i < shownQuestions.Length; i++)
			if (shownQuestions[i] == 0)
			{
				shownQuestions[i] = currentQuestion;
				break;
			}
		
	}

	// Add player a lista de players
	for (int l = 0; l < playerStats.GetLength(0); l++)
	{
		if (playerStats[l, 0] == null)
		{
			playerStats[l, 0] = currentName;
			playerStats[l, 1] = acertos.ToString();
			break;
		}
	}
	do
	{
		Console.Clear();
		Console.Write(" ・ Deseja continuar? [S/N] "); playAgain = Console.ReadLine()!.ToUpper();
		if (playAgain == "S") break;
		else if (playAgain == "N")
		{
			isPlaying = false;
			break;
		}
	} while (true);
}

// Bubble sort
for (int a = 0; a < playerStats.GetLength(0) - 1; a++)
{
	for (int b = 0; b < playerStats.GetLength(0) - 1; b++)
	{
		if (Convert.ToInt32(playerStats[b, 1]) < Convert.ToInt32(playerStats[a, 1]))
		{
			string auxNome = playerStats[b, 0];
			string auxScore = playerStats[b, 1];

			playerStats[b, 0] = playerStats[a, 0];
			playerStats[a, 0] = auxNome;

			playerStats[b, 1] = playerStats[a, 1];
			playerStats[a, 1] = auxScore;	
		}
	}
}

Console.Clear();
Console.WriteLine(" ・ PLACAR:");
for (int l = 0; l < playerStats.GetLength(0); l++)
	Console.Write( (playerStats[l, 0] != null) ? $"  ・  {playerStats[l, 0]} - {playerStats[l, 1]}/{quantShowQuestions}\n" : null);