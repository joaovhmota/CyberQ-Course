using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Forms.Classes
{
	public class SchoolClasses
	{
		public string Name { get; set; }
		public List<Student> Students { get; set; }
		public float ClassAvarage { get; set; }

		public SchoolClasses(string Name)
		{
			this.Name = Name;
			Students = new List<Student>();
			ClassAvarage = 0.0f;
		}

		public void UpdateAvarage()
		{
			ClassAvarage = 0.0f;

			Students.ForEach(s => {
				ClassAvarage += s.Avarage;
			});

			ClassAvarage /= Students.Count;
		}

		public void AddStudent(Student s)
		{
			Students.Add(s);
			UpdateAvarage();
		}
	}
}
