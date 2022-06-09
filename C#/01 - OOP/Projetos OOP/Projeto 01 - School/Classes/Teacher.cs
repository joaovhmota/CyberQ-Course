using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class Teacher : Person // 先生
	{
		public string  ID      { get; set; } // ID
		public float   Salary  { get; set; } // 給料
		public Subject Subject { get; set; } // 科目

		public Teacher(string Name, int Age, float Salary, Subject subject) : base(Name, Age)
		{
			this.ID      = new Util().UniqueID();
			this.Salary  = Salary;
			this.Subject = subject;
		}
	}
}
