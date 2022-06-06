using Exemplo_02;

void showInfo(Product product)
{
	Console.WriteLine($" ・ {product.Name} : {product.Price:C2}");
}

List<Product> products = new List<Product>();
Product product = new Product();
char opt;

do
{
	Console.Clear();
	product = new Product();

	Console.Write(" ・ Informe o nome do produto: ");
	product.Name = Console.ReadLine()!;

	Console.Write(" ・ Infome o valor do produto: ");
	product.Price = Convert.ToDouble(Console.ReadLine()!.Replace(',', '.'));

	Console.Clear();
	Console.WriteLine($"Produto ({product.Name} : {product.Price:C2}) adicionado com sucesso");
	products.Add(product);

	Console.Write("Continuar o laço? [S/N]: ");
	opt = Console.ReadLine()!.ToUpper().ToCharArray()[0];
	if (opt == 'N') break;
	else continue;
} while (true);

Console.Clear();
products.ForEach(showInfo);