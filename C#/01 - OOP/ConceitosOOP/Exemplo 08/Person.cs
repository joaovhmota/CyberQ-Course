using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_08
{
	internal class Person : Default
	{
		private string Name = string.Empty;
		private int Age = 0;

		public override void Introduction(string Name)
		{
			Console.WriteLine($"Hello, my name is {Name} and I'm {this.Age} years old");
		}
	}
}
