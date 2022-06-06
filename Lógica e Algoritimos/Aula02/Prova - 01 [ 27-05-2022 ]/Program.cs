string tempNome,
	  nomeMaisFaltou = "",
	  homemMaisSalario = "",
	  mulherMaisSalario = "";

int tempIdade;

char tempGender;

int totalCadastros = 0,
    tempCargo,
    tempFaltas,
    tempHoraExtra,
    tempPlanoSaude,
    tempParticipaClube,
    homens = 0,
    mulheres = 0,
    maxFaltas = 0,
    possuemPlanoSaude = 0,
    possuemAcessoClube = 0;

bool continuar = true;
	
double salarioBruto = 0,
	  valorHoraExtra = 0,
	  premioFaltas = 0,
	  temPlanoSaude = 0,
	  participaClube = 0,
	  maiorSalarioLiquidoHomem = 999999999,
	  maiorSalarioLiquidoMulher = 999999999,
	  salarioLiq;

char opt;

// Começo do Programa
do
{
	// Coleta do nome do funcionário
	do
	{
		try
		{
			Console.Write("\n ・ Digite o nome do funcionário: "); tempNome = Console.ReadLine()!;
			if ((tempNome != "") && !(tempNome.Contains("1") || tempNome.Contains("2") || tempNome.Contains("3") || tempNome.Contains("4") || tempNome.Contains("5") || tempNome.Contains("6") || tempNome.Contains("7") || tempNome.Contains("8") || tempNome.Contains("9") || tempNome.Contains("0")))
			{
				break;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\t ・ [O nome inserido é inválido] ・ \n");
				Console.ForegroundColor = ConsoleColor.White;
			}
		} catch (Exception ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\t ・ [{ex.Message}] ・ \n");
			Console.ForegroundColor = ConsoleColor.White;
		}
		
	} while (true);


	// Coleta da idade do funcionário
	do
	{
		try
		{
			Console.Write("\n ・ Digite a idade do funcionário (Precisa ser maior de 15 anos): "); tempIdade = Convert.ToInt32(Console.ReadLine()!);
			if (tempIdade > 15) break;
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\t ・ [A idade inserida é inválida] ・ \n");
				Console.ForegroundColor = ConsoleColor.White;
			}
		} catch (Exception ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\t ・ [{ex.Message}] ・ \n");
			Console.ForegroundColor = ConsoleColor.White;
		}
	} while (true);


	// Coleta do gênero do funcionário
	do
	{
		try
		{
			Console.Write("\n ・ Digite o gênero do funcionário [M / F]: "); tempGender = Console.ReadLine()!.ToUpper().ToCharArray()[0];
			if (tempGender == 'M') homens++;
			if (tempGender == 'F') mulheres++;
			if (tempGender == 'M' || tempGender == 'F') break;
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\t ・ [O gênero é inválido] ・ \n");
				Console.ForegroundColor = ConsoleColor.White;
			}
		} catch (Exception ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\t ・ [{ex.Message}] ・ \n");
			Console.ForegroundColor = ConsoleColor.White;
		}
	} while (true);


	// Coleta do cargo do usuário
	do
	{
		try
		{
			Console.WriteLine("\n ・ Indique o cargo do funcionário:");
			Console.WriteLine("\t ・ 1 - Desenvolvedor");
			Console.WriteLine("\t ・ 2 - Analista");
			Console.WriteLine("\t ・ 3 - Arquiteto");
			Console.WriteLine("\t ・ 4 - Gerente de Projetos");
			Console.Write("   >>> "); tempCargo = Convert.ToInt32(Console.ReadLine());
			if (tempCargo <= 4 && tempCargo >= 1) break;
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\t ・ [Opção selecionada é inválida] ・ \n");
				Console.ForegroundColor = ConsoleColor.White;
			}
		} catch (Exception ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\t ・ [{ex.Message}] ・ \n");
			Console.ForegroundColor = ConsoleColor.White;
		}
	} while (true);


	// Coleta das horas extras trabalhadas
	do
	{
		try
		{
			Console.Write("\n ・ Total de horas extras trabalhadas: "); tempHoraExtra = Convert.ToInt32(Console.ReadLine()!);
			if (tempHoraExtra > 0) break;
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\t ・ [A quantidade de horas inserida inválida] ・ \n");
				Console.ForegroundColor = ConsoleColor.White;
			}

		} catch (Exception ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\t ・ [{ex.Message}] ・ \n");
			Console.ForegroundColor = ConsoleColor.White;
		}
	} while (true);


	// Coletando se adere ao plano de saúde
	do
	{
		try
		{
			Console.WriteLine("\n ・ O funcionário adere ao plano de saúde?");
			Console.WriteLine(" ・ 1 - Sim");
			Console.WriteLine(" ・ 2 - Não");
			Console.Write("   >>> "); tempPlanoSaude = Convert.ToInt32(Console.ReadLine()!);
			if (tempPlanoSaude == 1) { temPlanoSaude = 300; possuemPlanoSaude++; }
			if (tempPlanoSaude == 1 || tempPlanoSaude == 2) break;
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\t ・ [Opção selecionada é inválida] ・ \n");
				Console.ForegroundColor = ConsoleColor.White;
			}
		} catch (Exception ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\t ・ [{ex.Message}] ・ \n");
			Console.ForegroundColor = ConsoleColor.White;
		}
	} while (true);


	// Coleta de faltas do funcionário
	do
	{
		try
		{
			Console.Write("\n ・ Total de faltas no ultimo mês: "); tempFaltas = Convert.ToInt32(Console.ReadLine()!);
			if (tempCargo == 0) premioFaltas = 100;
			if (tempFaltas <= 31 && tempFaltas >= 0) break;
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\t ・ [A quantidade de faltas inserida é inválida] ・ \n");
				Console.ForegroundColor = ConsoleColor.White;
			}
		} catch (Exception ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\t ・ [{ex.Message}] ・ \n");
			Console.ForegroundColor = ConsoleColor.White;
		}
	} while (true);


	// Coletando se o funcionário adere ao Clube (?)
	do
	{
		try
		{
			Console.WriteLine("\n ・ O funcionário adere ao clube?");
			Console.WriteLine(" ・ 1 - Sim");
			Console.WriteLine(" ・ 2 - Não");
			Console.Write("   >>> "); tempParticipaClube = Convert.ToInt32(Console.ReadLine()!);
			if (tempParticipaClube == 1) { participaClube = 100; possuemAcessoClube++; }
			if (tempParticipaClube == 1 || tempParticipaClube == 2) break;
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\t ・ [Opção selecionada é inválida] ・ \n");
				Console.ForegroundColor = ConsoleColor.White;
			}
		} catch (Exception ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\t ・ [{ex.Message}] ・ \n");
			Console.ForegroundColor = ConsoleColor.White;
		}
	} while (true);


	// Configurando o Salário do Funcionário
	switch (tempCargo)
	{
		case 1:
			salarioBruto = 3000;
			valorHoraExtra = 30;
			break;

		case 2:
			salarioBruto = 4500;
			valorHoraExtra = 45;

			break;

		case 3:
			salarioBruto = 7000;
			valorHoraExtra = 70;

			break;

		case 4:
			salarioBruto = 8500;
			valorHoraExtra = 85;

			break;
	}

	salarioLiq = (salarioBruto + premioFaltas + (tempHoraExtra * valorHoraExtra)) - participaClube - temPlanoSaude;
	// Mostrando ao usuário as informações do funcionário
	Console.WriteLine($"\n ・ Nome do funcionário: {tempNome}");
	Console.WriteLine($" ・ Salário Liquido: {salarioLiq:C2}");
	Console.WriteLine( (participaClube  > 0) ? " ・ Sim (R$100,00)" : " ・ Não (R$0,00)");
	Console.WriteLine( (temPlanoSaude  > 0) ? " ・ Sim (R$300,00)" : " ・ Não (R$0,00)");

	// Configurando 
	totalCadastros++;
	if (tempFaltas > maxFaltas) maxFaltas = tempFaltas;

	switch (tempGender)
	{
		case 'M':
			if (salarioLiq < maiorSalarioLiquidoHomem)
			{
				homemMaisSalario = tempNome;
				maiorSalarioLiquidoHomem = salarioLiq;
			}
			break;

		case 'F':
			if (salarioLiq < maiorSalarioLiquidoMulher)
			{
				mulherMaisSalario = tempNome;
				maiorSalarioLiquidoMulher = salarioLiq;
			}
			break;
	}

	// Verificar se vai adicionar mais um funcionário
	Console.Write("\n ・ Deseja adicionar mais um funcionário?\n   [S/N]: ");
	do
	{
		try
		{
			opt = Console.ReadLine()!.ToUpper().ToCharArray()[0];
			if (opt == 'S') { continuar = true; break; }
			else if (opt == 'N') { continuar = false; break; }
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\t ・ [Opção selecionada é inválida] ・ \n");
				Console.ForegroundColor = ConsoleColor.White;
			}
		} catch (Exception ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\t ・ [Opção selecionada é inválida] ・ \n");
			Console.ForegroundColor = ConsoleColor.White;
		}
		
	} while (true);

	Console.Clear();
} while (continuar);


Console.WriteLine(" ・ RESUMO DO CADASTRO ・ ");
Console.WriteLine($" ・ Total de registros: {totalCadastros} resigtros");
Console.WriteLine($" ・ Total de homens: {homens} homens ({(homens / totalCadastros) * 100}%)");
Console.WriteLine($" ・ Total de mulheres: {mulheres} mulheres ({(mulheres / totalCadastros) * 100}%)");
Console.WriteLine($" ・ Homem com maior salário liquído: {homemMaisSalario} ({maiorSalarioLiquidoHomem:C2})");
Console.WriteLine($" ・ Mulher com maior salário liquído: {mulherMaisSalario} ({maiorSalarioLiquidoMulher:C2})");
Console.WriteLine($" ・ Total de pessoas que possuem o plano de saúde: {possuemPlanoSaude} pessoas");
Console.WriteLine($" ・ Total de pessoas que possuem acesso ao clube: {possuemAcessoClube} pessoas");