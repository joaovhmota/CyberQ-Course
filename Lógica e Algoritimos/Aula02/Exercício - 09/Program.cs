double money,
	  tax,
	  time,
	  //total,
	  newTotal;

Console.Write("Quanto deseja investir?\n>>> "); 
money = Convert.ToDouble(Console.ReadLine());

Console.Write("Por quanto tempo?\n>>> ");       
time  = Convert.ToDouble(Console.ReadLine());

Console.Write("Qual é a taxa por mês?\n>>> ");  
tax   = Convert.ToDouble(Console.ReadLine());

// total = money * Math.Pow((1 + tax / 100), time);
//Console.WriteLine("O total, no final do temp será de: R${0}", total);

newTotal = money;
for (int i = 1; i <= time; i++)
{
	newTotal *= (1 + tax / 100);
	Console.WriteLine($"O total, no final do {i}° mês será de: {newTotal:C2}");
} 