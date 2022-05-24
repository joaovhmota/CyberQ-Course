// Console.WriteLine("Hello, World!");
int n1, n2, n3, maior, menor, medio;

Console.Write("Numero 1:"); n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Numero 2:"); n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Numero 3:"); n3 = Convert.ToInt32(Console.ReadLine());

maior = n1;
maior = (n2 > maior) ? n2 : maior;
maior = (n3 > maior) ? n3 : maior;

menor = n1;
menor = (n2 < menor) ? n2 : menor;
menor = (n3 < menor) ? n3 : menor;

medio = (n1 + n2 + n3) - (maior + menor);

Console.WriteLine("{0} => {1} => {2}", menor, medio, maior);