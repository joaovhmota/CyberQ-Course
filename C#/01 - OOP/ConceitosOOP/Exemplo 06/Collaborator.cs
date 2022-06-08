using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_06
{
	internal class Collaborator : Person
	{
		private string Role = "";
		private double Salary = 0.00;

		public Collaborator(string Name = "<Unknown>", int Age = -1, string Role = "<Unemployed>", double Salary = 0.00) : base(Name, Age)
		{
			this.Role = Role;
			this.Salary = Salary;
		}

		public void CollaboratorInfo()
		{
			this.Introduce();
			Console.WriteLine($"Role: {this.Role} | Salary: {this.Salary:C2}");
		}
	}
}
