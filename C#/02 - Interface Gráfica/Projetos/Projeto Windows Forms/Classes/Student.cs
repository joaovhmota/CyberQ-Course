using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Forms.Classes
{
	public class Student
	{
		public string		      Login { get; set; }
		public string		      Password { get; set; }
		public string		      Name { get; set; }
		public int		      Age { get; set; }
		public char		      Gender { get; set; }
		public float		      Avarage { get; set; }
		public List<TestResult>   Notes { get; set; }
		public bool	           IsLocked { get; set; }
		public byte	           Tries { get; set; }
		public bool	           IsInClass { get; set; }

		public Student(string Name, int Age, char Gender)
		{
			Login = $"St{Name.Replace(" ", "")}{Age}";
			Password = $"St{Name.Replace(" ", "")}{Age}";
			this.Name = Name;
			this.Age = Age;
			this.Gender = Gender;
			Avarage = 0.0f;
			Notes = new List<TestResult>();
			IsLocked = false;
			IsInClass = false;
		}

		public void UpdateInfo(string Name = "", int Age = 0, char Gender = ' ')
		{
			if (Name != "") this.Name = Name;
			if (Age != 0) this.Age = Age;
			if (Gender != ' ') this.Gender = Gender;
		}
		
		public void UpdateAvarage()
		{
			Avarage = 0.0f;
			Notes.ForEach(r => {
				Avarage += r.Result;
			});
			Avarage /= Notes.Count;
		}

		public void AddResult(TestResult? r)
		{
			if (r == null) return;

			Notes.Add(r);

			UpdateAvarage();
		}


		public override string ToString()
		{
			return Name;
		}
	}
}
