// Console.WriteLine("Hello, World!");

string nome;
int idade;

Console.Write("Seu nome: "); nome = Console.ReadLine();
Console.Write("Sua idade: "); idade = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Seu nome é {0} e seu ano de nascimento é {1}", nome, DateTime.Now.Year - idade);
