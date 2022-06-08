using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_09
{
	internal interface ICalculadora
	{
		public void Sum(float n1, float n2);
		public void Subtract(float n1, float n2);
		public void Divide(float n1, float n2);
		public void Multiply(float n1, float n2);
	}
}
