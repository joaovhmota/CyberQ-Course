using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class Subject // 科目
	{
		public string ID   { get; set; } // ID
		public string Name { get; set; } // 名

		public Subject(string Name)
		{
			this.ID = new Util().UniqueID();
			this.Name = Name;
		}
	}
}
