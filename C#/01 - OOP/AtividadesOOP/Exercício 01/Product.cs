using System;

namespace Exercício_01
{
	internal class Product
	{
		private string _Name;
		private double _Price;
		private string _Brand;
		private DateTime _ExpirationDate;
		private bool isValid;

		public string Name { get => _Name; set => _Name = value; }
		public double Price { get => _Price; set => _Price = value; }
		public string Brand { get => _Brand; set => _Brand = value; }
		public DateTime ExpirationDate { get => _ExpirationDate; set => _ExpirationDate = value; }
		public bool IsValid { get => isValid; set => isValid = value; }
	}
}
