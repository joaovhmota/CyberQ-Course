using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class Person // 人
	{
		public string Name { get; set; } // 氏名
		public int    Age  { get; set; } // 歳

		public Person(string Name, int Age)
		{
			this.Name = Name;
			this.Age = Age;
		}
	}
}
