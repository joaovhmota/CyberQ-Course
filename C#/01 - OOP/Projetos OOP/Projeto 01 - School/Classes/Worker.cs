using System;

namespace ProjetoSchool.Classes
{
	internal class Worker
	{
		public string ID { get; }
		public float Salary { get; set; }
		public string Role { get; set; }

		public Worker(float Salary, string Role)
		{
			this.ID = DateTime.Now.Ticks.ToString().Substring(0, DateTime.Now.Ticks.ToString().Length / 2);
			this.Salary = Salary;
			this.Role = Role;
		}
	}
}
