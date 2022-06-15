using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Forms.Classes
{
	public class Teacher
	{
		public string Login { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public int    Age { get; set; }
		
		public Teacher(string Name, int Age)
		{
			Login = $"Te{Name.Replace(" ", "")}{Age}";
			Password = $"Te{Name.Replace(" ", "")}{Age}";
			this.Name = Name;
			this.Age = Age;
		}
	}
}
