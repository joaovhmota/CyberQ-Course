using System;

namespace ProjetoSchool.Classes
{
	internal class Subject
	{
		public string ID { get; set; }
		public string SubjectName { get; set; }

		public Subject(string SubjectName = null)
		{
			this.ID = DateTime.Now.Ticks.ToString().Substring(0, DateTime.Now.Ticks.ToString().Length / 2);
			this.SubjectName = SubjectName;
		}
	}
}
