using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class SchoolClasses // 教室
	{
		public string        ID       { get; set; } // ID
		public List<Student> Students { get; set; } // 授業の学生
		public string        Name     { get; set; } // 授業の名
		public float         Avarage  { get; set; } // 平均

		public SchoolClasses(string Name)
		{
			this.ID       = new Util().UniqueID();
			this.Students = new List<Student>();
			this.Name     = Name; 
		}

		public void Update()
		{
			this.Avarage = 0f;
			this.Students.ForEach(s => {
				this.Avarage += s.StudentAvarage;
			});
			this.Avarage /= this.Students.Count;
		}

		public void AddStudent(Student student)
		{
			this.Students.Add(student);
			Update();
		}
	}
}
