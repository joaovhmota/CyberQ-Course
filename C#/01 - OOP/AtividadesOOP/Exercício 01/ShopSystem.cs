using System;

namespace Exercício_01
{
	internal class ShopSystem
	{
		private List<Product> registeredProducts = new List<Product>();
		public void Init()
		{
			bool isRunning = true;
			int opt;

			do
			{
				Console.Clear();
				Console.WriteLine(" ・ Menu ・ ");
				Console.WriteLine(" ・ 1 - Cadastrar");
				Console.WriteLine(" ・ 2 - Listar");
				Console.WriteLine(" ・ 3 - Verificar validade");
				Console.WriteLine(" ・ 4 - Alterar");
				Console.WriteLine(" ・ 5 - Remover");
				Console.WriteLine(" ・ 6 - Finalizar");
				Console.Write(">>> ");
				opt = Convert.ToInt32(Console.ReadLine());

				switch (opt)
				{
					case 1: this.AddProduct(); break;
					case 2: this.ShowProducts(); Console.ReadLine(); break;
					case 3: this.VerifyExpirationDate(); Console.ReadLine(); break;
					case 4: this.EditProduct(); break;
					case 5: this.RemoveProduct(); break;
					case 6: isRunning = false; break;
				}
			} while (isRunning);
		}

		private void AddProduct()
		{
			try
			{
				Product tempProduct = new Product();
				string[] tempDate;

				Console.Write(" ・ Informe o nome do produto: ");
				tempProduct.Name = Console.ReadLine();
				if (tempProduct.Name == "") tempProduct.Name = "<Unknown>";

				Console.Write(" ・ Informe o valor do produto: R$");
				tempProduct.Price = Convert.ToDouble(Console.ReadLine());

				Console.Write(" ・ Informe a marca do produto: ");
				tempProduct.Brand = Console.ReadLine();

				Console.Write(" ・ Informe a validade do produto: ");
				tempDate = Console.ReadLine()
							   .Replace('-', '/')
							   .Split('/');

				tempProduct.ExpirationDate = new DateTime(
					Convert.ToInt32(tempDate[2]),
					Convert.ToInt32(tempDate[1]),
					Convert.ToInt32(tempDate[0])
				);

				this.registeredProducts.Add(tempProduct);
			} catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
			}
			
		}

		private void ShowProducts()
		{
			for (int i = 0; i < this.registeredProducts.Count; i++)
				Console.WriteLine($" ・ {i+1}° {registeredProducts[i].Name} | {registeredProducts[i].Price} | {registeredProducts[i].Brand} | {registeredProducts[i].ExpirationDate.Date}");
		}

		private void VerifyExpirationDate()
		{
			for (int i = 0; i < this.registeredProducts.Count; i++)
				if (registeredProducts[i].ExpirationDate.Year == DateTime.Now.Year)
					if (registeredProducts[i].ExpirationDate.Month == DateTime.Now.Date.Month || registeredProducts[i].ExpirationDate.Month ==	DateTime.Now.Date.Month + 1)
						Console.WriteLine($" ・ {registeredProducts[i].Name} | {registeredProducts[i].Price} | {registeredProducts[i].Brand} | {registeredProducts[i].ExpirationDate.Date}");
		}

		private void EditProduct()
		{
			try
			{
				string[] tempDate;
				int opt;

				this.ShowProducts();
				Console.Write(" ・ Selecione o produto que deseja editar: ");
				opt = Convert.ToInt32(Console.ReadLine()) - 1;

				Console.Write(" ・ Digite o novo nome: ");
				registeredProducts[opt].Name = Console.ReadLine();

				Console.Write(" ・ Digite o novo preço: R$");
				registeredProducts[opt].Price = Convert.ToDouble(Console.ReadLine());

				Console.Write(" ・ Digite a nova marca: ");
				registeredProducts[opt].Brand = Console.ReadLine();

				Console.Write(" ・ Digite a nova data de validade: ");
				tempDate = Console.ReadLine()
							   .Replace('-', '/')
							   .Split('/');

				registeredProducts[opt].ExpirationDate = new DateTime(
					Convert.ToInt32(tempDate[2]),
					Convert.ToInt32(tempDate[1]),
					Convert.ToInt32(tempDate[0])
				);
			} catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
			}
		}

		private void RemoveProduct()
		{
			int opt;
			try
			{
				this.ShowProducts();
				Console.Write(" ・ Selecione o produto que deseja remover: ");
				opt = Convert.ToInt32(Console.ReadLine()) - 1;

				this.registeredProducts.Remove(this.registeredProducts[opt]);
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($" ・ {ex.Message} ・ ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
			}
		}
	}
}
