using System;

namespace ProjetoSchool.Classes
{
	internal class Student : Person
	{
		public string ID { get; }
		public List<float> StudentNotes;
		public List<Warning> WarningLists;
		public List<Suspension> SuspensionList;
		public float StudentAvarage { get; set; }
		public string Situation { get; set; }
		public List<Responsible> Responsibles;

		public Student(string CPF, string Name, int Age) : base(CPF, Name, Age)
		{
			this.ID = DateTime.Now.Ticks.ToString().Substring(0, DateTime.Now.Ticks.ToString().Length / 2);
			this.StudentAvarage = 0;
			this.StudentNotes = new List<float>();
			this.WarningLists = new List<Warning>();
			this.Responsibles = new List<Responsible>();
			this.SuspensionList = new List<Suspension>();
			this.Situation = "";
		}

		public void Update()
		{
			this.StudentAvarage = this.StudentNotes.Sum() / this.StudentNotes.Count;
		}

		public void AddNota(float n)
		{
			this.StudentNotes.Add(n);
			this.Update();
		}

		public void AddWarning(Warning warning)
		{
			this.WarningLists.Add(warning);
		}

		public void AddSuspension(Suspension suspension)
		{
			this.SuspensionList.Add(suspension);
		}
	}
}
