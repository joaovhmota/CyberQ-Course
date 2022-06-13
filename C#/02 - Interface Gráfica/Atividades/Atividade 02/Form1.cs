namespace Atividade_02
{
	public partial class formMain : Form
	{
		public formMain()
		{
			InitializeComponent();
		}

		private void btnStudentInfo_Click(object sender, EventArgs e)
		{
			float studentAvarage = (float) (num1.Value + num2.Value + num3.Value) / 3;
			string situation;

			if (studentAvarage < 5)
				situation = "reprovado";
			else if (studentAvarage < 7)
				situation = "em exame";
			else
				situation = "aprovado";

			MessageBox.Show($"{txtStudentName.Text}, com média {studentAvarage}, está {situation}");
		}
	}
}