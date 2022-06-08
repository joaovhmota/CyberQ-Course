using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_07
{
	internal class Developer : Default
	{
		public override void IncomeTax(double Salary)
		{
			Console.WriteLine($"Developer Default Income Tax: {Salary * 0.1}");
		}
	}
}
