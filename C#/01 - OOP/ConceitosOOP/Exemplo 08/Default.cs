using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_08
{
	internal abstract class Default
	{
		public void Message()
		{
			Console.WriteLine("Hello, World!");
		}

		public abstract void Introduction(string Name);
	}
}
