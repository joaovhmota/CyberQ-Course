using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_09
{
	internal class TheClass : ICalculadora, IScientificCalculator
	{
		public void Cosine(double Angle)
		{
			Console.WriteLine(":)");
		}

		public void Divide(float n1, float n2)
		{
			Console.WriteLine(n1 / n2);
		}

		public void Multiply(float n1, float n2)
		{
			Console.WriteLine(n1 * n2);
		}

		public void Sine(double Angle)
		{
			Console.WriteLine(":)");
		}

		public void Subtract(float n1, float n2)
		{
			Console.WriteLine(n1 - n2);
		}

		public void Sum(float n1, float n2)
		{
			Console.WriteLine(n1 + n2);
		}

		public void Tangent(double Angle)
		{
			Console.WriteLine(":)");
		}
	}
}
