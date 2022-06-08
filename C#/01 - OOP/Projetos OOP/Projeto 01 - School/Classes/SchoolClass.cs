using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class SchoolClass
	{
		public string ID { get; set; }
		public List<Student> ClassStudents { get; set; }
		public string ClassName;
		public float ClassAvarage { get; set; }

		public SchoolClass(string ClassName)
		{
			this.ID = DateTime.Now.Ticks.ToString().Substring(0, DateTime.Now.Ticks.ToString().Length / 2);
			this.ClassStudents = new List<Student>();
			this.ClassAvarage = 0.0f;
			this.ClassName = ClassName;
		}

		public void AddStudent(Student student)
		{
			this.ClassStudents.Add(student);
			this.Update();
		}

		private void AddStudentAvarageToClassAvarage(Student s)
		{
			this.ClassAvarage += s.StudentAvarage;
		}

		public void Update()
		{
			this.ClassAvarage = 0.0f;
			this.ClassStudents.ForEach(this.AddStudentAvarageToClassAvarage);
			this.ClassAvarage /= this.ClassStudents.Count;
		}
	}
}
