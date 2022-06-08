using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_07
{
	internal class Default
	{
		public void TransportPass(double Salary)
		{
			Console.WriteLine($"Default Transport Pass: {Salary * 0.06}");
		}

		public virtual void IncomeTax(double Salary)
		{
			Console.WriteLine($"Default Income Tax: {Salary * 0.05}");
		}
	}
}
