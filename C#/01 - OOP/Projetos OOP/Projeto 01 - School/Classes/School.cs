using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSchool.Interfaces;

namespace ProjetoSchool.Classes
{
	internal class School : ISchoolSystem
	{
		public string              Name          { get; set; }
		public List<SchoolClasses> SchoolClasses { get; set; }
		public List<Student>       Students      { get; set; }
		public List<Subject>       Subjects      { get; set; }
		public List<Teacher>       Teachers      { get; set; }
		public List<Worker>        Workers       { get; set; }
		public float               Avarage       { get; set; }
		public float               MinAvarage    { get; set; }

		public School(string Name, float MinAvarage)
		{
			this.Name          = Name;
			this.MinAvarage    = MinAvarage;
			this.SchoolClasses = new List<SchoolClasses>();
			this.Students      = new List<Student>();
			this.Subjects      = new List<Subject>();
			this.Teachers      = new List<Teacher>();
			this.Workers       = new List<Worker>();
		}

		public School Update()
		{
			this.Avarage = 0f;
			this.SchoolClasses.ForEach(x => {
				this.Avarage += x.Avarage;
			});
			return this;
		}

		public void UpdateStudentSituation()
		{
			Students.ForEach( s =>
			{
				if (s.StudentAvarage >= MinAvarage) s.Situation = "Aprovado";
				else s.Situation = "Reprovado";
			});
		}
	}
}
