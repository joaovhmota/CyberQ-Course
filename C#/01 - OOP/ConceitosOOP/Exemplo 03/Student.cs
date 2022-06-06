using System;

namespace Exemplo_03
{
	internal class Student
	{ 
		public string Name;
		public List<double> Notas = new List<double>();
		public double Avarage;

		public Student(string name = "<Unknown>")
		{
			this.Name = name;
			this.Notas = new List<double>();
			this.Avarage = 0.00;
		}

		private void Update()
		{
			this.Avarage = ( this.Notas.Sum() / this.Notas.Count );
		}

		public void AddNote(double n)
		{
			this.Notas.Add(n);
			this.Update();
		}
	}
}
