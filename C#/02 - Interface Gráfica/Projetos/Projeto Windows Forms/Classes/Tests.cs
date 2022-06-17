using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Forms.Classes
{
	public class Tests
	{
		public string Title { get; set; }
		public DateTime AppliedDate { get; set; }

		public Tests (string Title, DateTime Date)
		{
			this.Title = Title;
			AppliedDate = Date;
		}
	}
}
