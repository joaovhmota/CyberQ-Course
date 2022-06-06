bool isRunning = true;

string name,
	  tempName,
	  state,
	  tempState,
	  oldestName    = "",
	  youngestName  = "",
	  youngestState = "",
	  oldestState   = "";

int age,
	tempAge,
	oldestAge   = 0,
	youngestAge = 999;

int totalUsers    = 0,
    totalStateAC  = 0,
    totalStateAL  = 0,
    totalStateAP  = 0,
    totalStateAM  = 0,
    totalStateBA  = 0,
    totalStateCE  = 0,
    totalStateDF  = 0,
    totalStateES  = 0,
    totalStateGO  = 0,
    totalStateMA  = 0,
    totalStateMT  = 0,
    totalStateMS  = 0,
    totalStateMG  = 0,
    totalStatePA  = 0,
    totalStatePB  = 0,
    totalStatePR  = 0,
    totalStatePE  = 0,
    totalStatePI  = 0,
    totalStateRJ  = 0,
    totalStateRN  = 0,
    totalStateRS  = 0,
    totalStateRO  = 0,
    totalStateRR  = 0,
    totalStateSC  = 0,
    totalStateSP  = 0,
    totalStateSE  = 0,
    totalStateTO  = 0;
    

double totalMen   = 0,
	  totalWoman = 0;

char genre,
	oldestGenre   = ' ',
	youngestGenre = ' ';

while (isRunning)
{
	try
	{
		Console.WriteLine("\n\t・ CADASTRO DE PESSOAS ・");
		Console.Write("\t・ Digite o nome da Pessoa [0 para cancelar]: "); tempName = Console.ReadLine()!;
		if (tempName == "") throw new Exception("Invalid name");
		else if (tempName == "0") { isRunning = false; break; }

		Console.Write("\t・ Digite a idade da Pessoa: "); tempAge = Convert.ToInt32(Console.ReadLine()!);
		if (tempAge <= 0) throw new Exception("Invalid age");

		Console.Write("\t・ Digite seu gênero [M/F]: "); genre = Console.ReadLine()!.ToUpper().ToCharArray()[0];
		if (genre != 'M' && genre != 'F') throw new Exception("Invalid genre");

		Console.Write("\t・ Digite o estado que você nasceu (UF): "); tempState = Console.ReadLine()!.ToUpper();
		if (tempState.Length != 2) throw new Exception("Invalid state");

		switch (tempState)
		{
			case "AC":
				totalStateAC++;
				break;

			case "AL":
				totalStateAL++;
				break;

			case "AP":
				totalStateAP++;
				break;

			case "AM":
				totalStateAM++;
				break;

			case "BA":
				totalStateBA++;
				break;

			case "CE":
				totalStateCE++;
				break;

			case "DF":
				totalStateDF++;
				break;

			case "ES":
				totalStateES++;
				break;

			case "GO":
				totalStateGO++;
				break;

			case "MA":
				totalStateMA++;
				break;

			case "MT":
				totalStateMT++;
				break;

			case "MS":
				totalStateMS++;
				break;

			case "MG":
				totalStateMG++;
				break;

			case "PA":
				totalStatePA++;
				break;

			case "PB":
				totalStatePB++;
				break;

			case "PR":
				totalStatePR++;
				break;

			case "PE":
				totalStatePE++;
				break;

			case "PI":
				totalStatePI++;
				break;

			case "RJ":
				totalStateRJ++;
				break;

			case "RN":
				totalStateRN++;
				break;

			case "RS":
				totalStateRS++;
				break;

			case "RO":
				totalStateRO++;
				break;

			case "RR":
				totalStateRR++;
				break;

			case "SC":
				totalStateSC++;
				break;

			case "SP":
				totalStateSP++;
				break;

			case "SE":
				totalStateSE++;
				break;

			case "TO":
				totalStateTO++;
				break;

			default:
				throw new Exception("Invalid State");
		}


		totalUsers++;
		name  = tempName;
		age   = tempAge;
		state = tempState;

		if (genre == 'M') totalMen++;
		else totalWoman++;

		if (age >= oldestAge)
		{
			oldestName  = name;
			oldestAge   = age;
			oldestGenre = genre;
			oldestState = state;
		}
		if (age <= youngestAge)
		{
			youngestName  = name;
			youngestAge   = age;
			youngestGenre = genre;
			youngestState = state;
		}
		Console.Clear();

	} catch (Exception e)
	{
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"\n\t ・ [{e.Message}] ・ ");
		Console.ForegroundColor = ConsoleColor.White;
	}
}

Console.Clear();
Console.WriteLine($"\n ・ Total de usuários: {totalUsers} usuários\n");
Console.WriteLine($" ・ Total de homens: {totalMen} homens ({(totalMen / totalUsers):P2})");
Console.WriteLine($" ・ Total de mulheres: {totalWoman} mulheres ({(totalWoman / totalUsers):P2})");

Console.WriteLine($" ・ Pessoa mais velha:");
Console.WriteLine($"\t ・ Nome: {oldestName}");
Console.WriteLine($"\t ・ Idade: {oldestAge}");
Console.WriteLine($"\t ・ Sexo: {oldestGenre}");
Console.WriteLine($"\t ・ Estado: {oldestState}");

Console.WriteLine($" ・ Pessoa mais nova:");
Console.WriteLine($"\t ・ Nome: {youngestName}");
Console.WriteLine($"\t ・ Idade: {youngestAge}");
Console.WriteLine($"\t ・ Sexo: {youngestGenre}");
Console.WriteLine($"\t ・ Estado: {youngestState}\n");

Console.WriteLine(" ・ Quantidade de pessoas por estado:");
Console.Write((totalStateAC > 0) ? $"\t ・ AC: {totalStateAC} pessoas\n" : null);
Console.Write((totalStateAL > 0) ? $"\t ・ AL: {totalStateAL} pessoas\n" : null);
Console.Write((totalStateAP > 0) ? $"\t ・ AP: {totalStateAP} pessoas\n" : null);
Console.Write((totalStateAM > 0) ? $"\t ・ AM: {totalStateAM} pessoas\n" : null);
Console.Write((totalStateBA > 0) ? $"\t ・ BA: {totalStateBA} pessoas\n" : null);
Console.Write((totalStateCE > 0) ? $"\t ・ CE: {totalStateCE} pessoas\n" : null);
Console.Write((totalStateDF > 0) ? $"\t ・ DF: {totalStateDF} pessoas\n" : null);
Console.Write((totalStateES > 0) ? $"\t ・ ES: {totalStateES} pessoas\n" : null);
Console.Write((totalStateGO > 0) ? $"\t ・ GO: {totalStateGO} pessoas\n" : null);
Console.Write((totalStateMA > 0) ? $"\t ・ MA: {totalStateMA} pessoas\n" : null);
Console.Write((totalStateMT > 0) ? $"\t ・ MT: {totalStateMT} pessoas\n" : null);
Console.Write((totalStateMS > 0) ? $"\t ・ MS: {totalStateMS} pessoas\n" : null);
Console.Write((totalStateMG > 0) ? $"\t ・ MG: {totalStateMG} pessoas\n" : null);
Console.Write((totalStatePA > 0) ? $"\t ・ PA: {totalStatePA} pessoas\n" : null);
Console.Write((totalStatePB > 0) ? $"\t ・ PB: {totalStatePB} pessoas\n" : null);
Console.Write((totalStatePR > 0) ? $"\t ・ PR: {totalStatePR} pessoas\n" : null);
Console.Write((totalStatePE > 0) ? $"\t ・ PE: {totalStatePE} pessoas\n" : null);
Console.Write((totalStatePI > 0) ? $"\t ・ PI: {totalStatePI} pessoas\n" : null);
Console.Write((totalStateRJ > 0) ? $"\t ・ RJ: {totalStateRJ} pessoas\n" : null);
Console.Write((totalStateRN > 0) ? $"\t ・ RN: {totalStateRN} pessoas\n" : null);
Console.Write((totalStateRS > 0) ? $"\t ・ RS: {totalStateRS} pessoas\n" : null);
Console.Write((totalStateRO > 0) ? $"\t ・ RO: {totalStateRO} pessoas\n" : null);
Console.Write((totalStateRR > 0) ? $"\t ・ RR: {totalStateRR} pessoas\n" : null);
Console.Write((totalStateSC > 0) ? $"\t ・ SC: {totalStateSC} pessoas\n" : null);
Console.Write((totalStateSP > 0) ? $"\t ・ SP: {totalStateSP} pessoas\n" : null);
Console.Write((totalStateSE > 0) ? $"\t ・ SE: {totalStateSE} pessoas\n" : null);
Console.Write((totalStateTO > 0) ? $"\t ・ TO: {totalStateTO} pessoas\n" : null);