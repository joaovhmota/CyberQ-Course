// Console.WriteLine("Hello, World!");

int idade;

Console.Write("Digite sua idade: ");
idade = Convert.ToInt16( Console.Read());

if (idade >= 18)
{
    Console.WriteLine("Apto para obter a CNH");
}
else
{
    Console.WriteLine("Não esá apto para obter a CNH");
}