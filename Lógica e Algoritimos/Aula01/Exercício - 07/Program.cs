// Console.WriteLine("Hello, World!");

int n1, n2, n3, menor;

Console.Write("Número 1: "); n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Número 2: "); n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Número 3: "); n3 = Convert.ToInt32(Console.ReadLine());

menor = n1;
menor = (n2 < menor) ? n2 : menor;
menor = (n3 < menor) ? n3 : menor;

Console.WriteLine("O maior número é: {0}", menor);