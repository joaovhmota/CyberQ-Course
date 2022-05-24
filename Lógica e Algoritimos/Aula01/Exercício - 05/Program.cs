// Console.WriteLine("Hello, World!");

int anoInput = 0;

Console.Write("Digite um ano: ");
anoInput = Convert.ToInt16( Console.ReadLine() );

//Console.WriteLine(DateTime.IsLeapYear(anoInput));
if ( anoInput % 4 == 0 && anoInput % 100 != 0 && anoInput % 400 == 0)
{
    Console.WriteLine("É um ano bissexto");
} 
else
{
    Console.WriteLine("Não é um ano bissexto");
}