// Console.WriteLine("Hello, World!");

string nomeProduto = "<noName>";
float  valorProduto = 0.0f;

Console.Write("Nome do produto: "); nomeProduto = Console.ReadLine();
Console.Write("Valor do produto (em R$): "); valorProduto = (float) Convert.ToDecimal(Console.ReadLine());

Console.Clear();

Console.WriteLine("Com 10% de desconto, {0} fica com o total de: R${1}", nomeProduto, valorProduto * 0.9);

