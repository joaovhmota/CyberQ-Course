using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class Worker : Person // 学校の従業員
	{
		public string ID     { get; set; } // ID
		public float  Salary { get; set; } // 給料
		public string Role   { get; set; } // 役

		public Worker(string Name, int Age, float Salary, string Role) : base(Name, Age)
		{
			this.ID     = new Util().UniqueID();
			this.Salary = Salary;
			this.Role   = Role;
		}
	}
}
