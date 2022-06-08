using System;
using ProjetoSchool.Classes;

namespace ProjetoSchool.Interfaces
{
	internal interface ISchoolSystem
	{
		public string SchoolName { get; set; }
		public List<SchoolClass> SchoolClasses { get; set; }
		public List<Student> RegisteredStudents { get; set; }
		public List<Teacher> RegisteredTeachers { get; set; }
		public List<Subject> RegisteredSubjects { get; set; }
		public List<Student> ApprovedStudents { get; set; }
		public List<Student> DisapprovedStudents { get; set; }
		public float SchoolAvarage { get; set; }
		public float SchoolMinimumAvarage { get; set; }

		public void Update();
		public void Update(Student student);
		public void Update(Subject subject);
		public void ShowStats();
		public void Search();
		public void Add(Student student);
		public void Add(Teacher teacher);
		public void Add(SchoolClass schoolClass);
		public void Add(Subject subject);
		public void Remove(Student student);
		public void Remove(Teacher teacher);
		public void Remove(SchoolClass schoolClass);
		public void Remove(Subject subject);

		public void ListStudents();
		public void ListTeachers();
		public void ListSubjects();
		public void ListClasses();
	}
}
