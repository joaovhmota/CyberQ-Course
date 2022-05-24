// Console.WriteLine("Hello, World!");

string nome;
string cidade;
int idade;

Console.Write("Digite seu nome: "); 
nome = Console.ReadLine();

Console.Write("Digite a cidade em que você mora: ");
cidade = Console.ReadLine();

Console.Write("Digite a sua idade: ");
idade = Convert.ToInt16( Console.ReadLine() );

Console.Clear();

Console.WriteLine("Olá, {0}! Agora sei que você mora em {1} e tem {2} anos :)", nome, cidade, idade);
