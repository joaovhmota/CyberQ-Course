using System;

namespace Exercício_03
{
	internal class Student
	{
		// Attributes
		private string _Name = "";
		private List<double> _Notes = new List<double>();
		private double _Avarage = 0.00;
		private string _Situation = "";

		// Getters & Setters
		public string Name { get => _Name; set => _Name = value; }
		public List<double> Notes { get => _Notes; set => _Notes = value; }
		public double Avarage { get => _Avarage; set => _Avarage = value; }
		public string Situation { get => _Situation; set => _Situation = value; }

		// Methods
		public void AddNote(double value) 
		{
			this.Notes.Add(value);
			Update();
		}

		private void Update()
		{
			this.Avarage = this.Notes.Sum() / this.Notes.Count;
		}
	}
}
