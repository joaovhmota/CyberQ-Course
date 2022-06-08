using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class Teacher : Person
	{
		public string ID { get; }
		public float Salary { get; set; }
		public Subject Subject { get; set; }

		public Teacher(string CPF, string Name, int Age, float Salary, Subject subject) : base(CPF, Name, Age)
		{
			this.ID = DateTime.Now.Ticks.ToString().Substring(0, DateTime.Now.Ticks.ToString().Length / 2);
			this.Salary = Salary;
			this.Subject = subject;
		}
	}
}
