// Console.WriteLine("Hello, World!");

float  media     = 0f;
string situation = "";

Console.Write("Digite sua media: "); 
media = (float) Convert.ToInt16(Console.Read());

if (media <= 10 && media >= 0)
{
    // Media válida!
    if (media >= 7)
        situation = "Aprovado";

    else if (media >= 5)
        situation = "Em exame";

    Console.WriteLine(situation);
}
else
{
    // Media inválida!
    Console.WriteLine("Média inválida!");
}