// Console.WriteLine("Hello, World!");

float    n1, n2, n3;
float    media;
string   situation;

Console.Write("Nota 1: "); n1 = (float) Convert.ToDecimal(Console.ReadLine());
Console.Write("Nota 2: "); n2 = (float) Convert.ToDecimal(Console.ReadLine());
Console.Write("Nota 3: "); n3 = (float) Convert.ToDecimal(Console.ReadLine());

media = (n1 + n2 + n3) / 3;

if (media <= 10 && media >= 7)
    situation = "Aprovado";

else if (media <= 6.9 && media >= 5)
    situation = "Em exame";

else
    situation = "Reprovado";

Console.WriteLine(situation);