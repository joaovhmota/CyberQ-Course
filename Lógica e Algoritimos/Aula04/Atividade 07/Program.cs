string anoPorExtenso(string data)
{
	string dia = "",
	       mes = "",
	       ano = "";

	int quantMil = 0,
	    quantCem = 0,
	    quantDez = 0,
	    quantUni = 0;

	// Verifica e formata a data para usar o '/'
	if (data.Contains("/") && data.Contains("-")) return "Data inválida";
	data = data.Replace("-", "/");

	// Coloca a data num array
	int[] dataSplit = { Convert.ToInt32(data.Split('/')[0]),   // Dia
		               Convert.ToInt32(data.Split('/')[1]),   // Mês
		               Convert.ToInt32(data.Split('/')[2]),}; // Ano

	if (dataSplit.Length != 3) return "Data inválida";

	while (dataSplit[2] - 1000 >= 0)
	{
		dataSplit[2] -= 1000;
		quantMil++;
	}

	while (dataSplit[2] - 100 >= 0)
	{
		dataSplit[2] -= 100;
		quantCem++;
	}

	while (dataSplit[2] - 10 >= 0)
	{
		dataSplit[2] -= 10;
		quantDez++;
	}
	while (dataSplit[2] - 1 >= 0)
	{
		dataSplit[2] -= 1;
		quantUni++;
	}

	if (dataSplit[1] < 13 && dataSplit[1] > 0) // Verifica os meses
		if (dataSplit[0] < 32 && dataSplit[0] > 0) // Verifica os dias
			if (dataSplit[2] <= DateTime.Now.Year) // Verifica o ano
			{
				switch (dataSplit[1])
				{
					case 1: mes = " de Janeiro"; break; 
					case 2: mes = " de Fevereiro"; break;
					case 3: mes = " de Março"; break;
					case 4: mes = " de Abril"; break;
					case 5: mes = " de Maio"; break;
					case 6: mes = " de Junho"; break;
					case 7: mes = " de Julho"; break;
					case 8: mes = " de Agosto"; break;
					case 9: mes = " de Setembro"; break;
					case 10: mes = " de Outubro"; break;
					case 11: mes = " de Novembro"; break;
					case 12: mes = " de Dezembro"; break;
				}
				switch (dataSplit[0])
				{
					case 1: dia = "Primeiro"; break;
					case 2: dia = "Dois"; break;
					case 3: dia = "Três"; break;
					case 4: dia = "Quatro"; break;
					case 5: dia = "Cinco"; break;
					case 6: dia = "Seis"; break;
					case 7: dia = "Sete"; break;
					case 8: dia = "Oito"; break;
					case 9: dia = "Nove"; break;
					case 10: dia = "Dez"; break;
					case 11: dia = "Onze"; break;
					case 12: dia = "Doze"; break;
					case 13: dia = "Treze"; break;
					case 14: dia = "Quatorze"; break;
					case 15: dia = "Quinte"; break;
					case 16: dia = "Dezesseis"; break;
					case 17: dia = "Dezessete"; break;
					case 18: dia = "Dezoito"; break;
					case 19: dia = "Dezenove"; break;
					case 20: dia = "Vinte"; break;
					case 21: dia = "Vinte e um"; break;
					case 22: dia = "Vinte e dois"; break;
					case 23: dia = "Vinte e três"; break;
					case 24: dia = "Vinte e quatro"; break;
					case 25: dia = "Vinte e cinco"; break;
					case 26: dia = "Vinte e seis"; break;
					case 27: dia = "Vinte e sete"; break;
					case 28: dia = "Vinte e oito"; break;
					case 29: dia = "Vinte e nove"; break;
					case 30: dia = "Trinta"; break;
					case 31: dia = "Trinta e um"; break;
				}
				if (quantMil == 0 && quantCem == 0 && quantDez == 0 && quantUni == 0) // 0000
				{
					ano = " do Zero";
				}
				else
				{
					if (quantDez == 0)
						switch (quantUni)
						{
							case 1: ano = " Um" + ano; break;
							case 2: ano = " Dois" + ano; break;
							case 3: ano = " Três" + ano; break;
							case 4: ano = " Quatro" + ano; break;
							case 5: ano = " Cinco" + ano; break;
							case 6: ano = " Seis" + ano; break;
							case 7: ano = " Sete" + ano; break;
							case 8: ano = " Oito" + ano; break;
							case 9: ano = " Nove" + ano; break;
							case 0: ano = "" + ano; break;
						}
					

					if (quantUni == 0)
					{
						switch (quantDez)
						{
							case 1: ano = " Dez" + ano; break;
							case 2: ano = " Vinte" + ano; break;
							case 3: ano = " Trinta" + ano; break;
							case 4: ano = " Quarenta" + ano; break;
							case 5: ano = " Cinquenta" + ano; break;
							case 6: ano = " Sessenta" + ano; break;
							case 7: ano = " Setenta" + ano; break;
							case 8: ano = " Oitenta" + ano; break;
							case 9: ano = " Noventa" + ano; break;
							case 0: ano = "" + ano; break;
						}
					}

					else if (quantDez == 1)
					{
						switch (quantUni)
						{

							case 1: ano = " Onze" + ano; break;
							case 2: ano = " Doze" + ano; break;
							case 3: ano = " Treze" + ano; break;
							case 4: ano = " Quatorze" + ano; break;
							case 5: ano = " Quinze" + ano; break;
							case 6: ano = " Dezesseis" + ano; break;
							case 7: ano = " Dezessete" + ano; break;
							case 8: ano = " Dezoito" + ano; break;
							case 9: ano = " Dezenove" + ano; break;
							case 0: ano = "" + ano; break;
						}
					}

					else if (quantDez > 1)
					{
						switch (quantUni)
						{
							case 1: ano = " Um" + ano; break;
							case 2: ano = " Dois" + ano; break;
							case 3: ano = " Três" + ano; break;
							case 4: ano = " Quatro" + ano; break;
							case 5: ano = " Cinco" + ano; break;
							case 6: ano = " Seis" + ano; break;
							case 7: ano = " Sete" + ano; break;
							case 8: ano = " Oito" + ano; break;
							case 9: ano = " Nove" + ano; break;
							case 0: ano = "" + ano; break;
						}
						ano = " e" + ano;
						switch (quantDez)
						{
							case 2: ano = " Vinte" + ano; break;
							case 3: ano = " Trinta" + ano; break;
							case 4: ano = " Quarenta" + ano; break;
							case 5: ano = " Cinquenta" + ano; break;
							case 6: ano = " Sessenta" + ano; break;
							case 7: ano = " Setenta" + ano; break;
							case 8: ano = " Oitenta" + ano; break;
							case 9: ano = " Noventa" + ano; break;
							case 0: ano = "" + ano; break;
						}
					}

					if (quantCem != 0 && (quantDez != 0 || quantUni != 0))
						ano = " e" + ano;

					switch (quantCem)
					{
						case 1:
							if (quantDez > 0 || quantUni > 0)
								ano = " Cento" + ano;
							else
								ano = " Cem" + ano;
							break;
						case 2: ano = " Duzentos" + ano; break;
						case 3: ano = " Trezentos" + ano; break;
						case 4: ano = " Quatrocentos" + ano; break;
						case 5: ano = " Quinhentos" + ano; break;
						case 6: ano = " Seiscentos" + ano; break;
						case 7: ano = " Setecentos" + ano; break;
						case 8: ano = " Oitocentos" + ano; break;
						case 9: ano = " Novecentos" + ano; break;
						case 0: ano = "" + ano; break;
					}

					if (quantMil > 0 && quantCem == 0 && (quantDez != 0 || quantUni != 0))
						ano = " e" + ano;

					switch (quantMil)
					{
						case 1: ano = " Mil" + ano; break;
						case 2: ano = " Dois mil" + ano; break;
						case 3: ano = " Três mil" + ano; break;
						case 4: ano = " Quatro mil" + ano; break;
						case 5: ano = " Cinco mil" + ano; break;
						case 6: ano = " Seismil" + ano; break;
						case 7: ano = " Sete mil" + ano; break;
						case 8: ano = " Oito mil" + ano; break;
						case 9: ano = " Nove mil" + ano; break;
						case 0: ano = "" + ano; break;
					}
					ano = " de" + ano;
				}
			}
	return $"[ {data}: " + dia + mes + ano + " ]";
}

/*
Console.WriteLine(anoPorExtenso("4-4-1")); 
Console.WriteLine(anoPorExtenso("4-4-10")); 
Console.WriteLine(anoPorExtenso("4-4-11"));
Console.WriteLine(anoPorExtenso("4-4-100")); 
Console.WriteLine(anoPorExtenso("4-4-101")); 
Console.WriteLine(anoPorExtenso("4-4-110")); 
Console.WriteLine(anoPorExtenso("4-4-111"));
Console.WriteLine(anoPorExtenso("4-4-1000"));
Console.WriteLine(anoPorExtenso("4-4-1001"));  
Console.WriteLine(anoPorExtenso("4-4-1010"));
Console.WriteLine(anoPorExtenso("4-4-1011"));
Console.WriteLine(anoPorExtenso("4-4-1100"));
Console.WriteLine(anoPorExtenso("4-4-1101"));  
Console.WriteLine(anoPorExtenso("4-4-1110"));
Console.WriteLine(anoPorExtenso("4-4-1111"));
*/


Random rnd = new Random();
int dia;
int mes;
int ano;
while (true)
{
	dia = 1 + rnd.Next(31);
	mes = 1 + rnd.Next(11);
	ano = 1 + rnd.Next(DateTime.Now.Year - 1);
	Console.Clear();
	Console.WriteLine($"Dia: {dia} | Mês: {mes} | {ano}");
	Console.WriteLine(anoPorExtenso($"{dia}/{mes}/{ano}"));
	Thread.Sleep(10000);
}