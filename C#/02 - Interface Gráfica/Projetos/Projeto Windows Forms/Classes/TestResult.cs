using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Forms.Classes
{
	public class TestResult
	{
		public Tests Test { get; set; }
		public float Result { get; set; }

		public TestResult(Tests t, float r)
		{
			Test = t;
			Result = r;
		}
	}
}
