using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_19
{
	internal class Product
	{
		public string Name { get; set; }
		public float Price { get; set; }
		public Brand Brand { get; set; }

		public Product(string Name, float Price, Brand Brand)
		{
			this.Name = Name;
			this.Price = Price;
			this.Brand = Brand;
		}
	}
}
