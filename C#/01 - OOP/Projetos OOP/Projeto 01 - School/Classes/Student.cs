using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSchool.Classes
{
	internal class Student : Person // 学生
	{
		public string               ID             { get; set; } // ID
		public List<float>          Notes          { get; set; } 
		public List<Warning>        Warnings       { get; set; } // 警告
		public List<Suspension>     Suspensions    { get; set; } // 休学
		public List<StudentParents> Parents        { get; set; } // 両親
		public string               Situation      { get; set; }
		public float                StudentAvarage { get; set; } // 平均

		public Student(string Name, int Age) : base(Name, Age)
		{
			this.ID             = new Util().UniqueID();
			this.Notes          = new List<float>();
			this.Warnings       = new List<Warning>();
			this.Suspensions    = new List<Suspension>();
			this.Parents        = new List<StudentParents>(); 
			this.Situation      = "";
			this.StudentAvarage = 0.0f;
		}

		public void Update()
		{
			StudentAvarage = Notes.Sum() / Notes.Count;
		}

		public void AddNote(float note)
		{
			this.Notes.Add(note);
			Update();
		}
	}
}
