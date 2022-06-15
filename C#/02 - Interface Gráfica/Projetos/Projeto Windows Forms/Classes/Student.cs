using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Forms.Classes
{
	public class Student
	{
		public string		 Login { get; set; }
		public string		 Password { get; set; }
		public string		 Name { get; set; }
		public int		 Age { get; set; }
		public char		 Gender { get; set; }
		public float		 Avarage { get; set; }
		public List<float>   Notes { get; set; }
		public bool          IsLocked { get; set; }
		public byte          Tries { get; set; }

		public Student(string Name, int Age, char Gender )
		{
			Login = $"St{Name.Replace(" ", "")}{Age}";
			Password = $"St{Name.Replace(" ", "")}{Age}";
			this.Name = Name;
			this.Age = Age;
			this.Gender = Gender;
			Avarage = 0.0f;
			Notes = new List<float>();
			IsLocked = false;
		}

		public void UpdateInfo(string Name = "", int Age = 0, char Gender = ' ')
		{
			if (Name != "") this.Name = Name;
			if (Age != 0) this.Age = Age;
			if (Gender != ' ') this.Gender = Gender;
		}

		public void AddNote(float note = -1)
		{
			if (note == -1) return;
			Notes.Add(note);
			Avarage = Notes.Sum() / Notes.Count;
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
}
