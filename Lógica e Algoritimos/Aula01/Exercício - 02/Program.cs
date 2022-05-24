// Console.WriteLine("Hello, World!");

float m1, m2;

Console.WriteLine("Digite suas duas notas: ");
Console.Write("Média 1: "); m1 = (float) Convert.ToDecimal( Console.ReadLine() );
Console.Write("Média 2: "); m2 = (float) Convert.ToDecimal( Console.ReadLine() );

Console.Clear();
Console.WriteLine("Sua média é de: {0}", (m1 + m2) / 2);