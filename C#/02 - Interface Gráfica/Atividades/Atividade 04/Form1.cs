namespace Atividade_04
{
	public partial class formMain : Form
	{
		public formMain()
		{
			InitializeComponent();
		}

		private void btnAvaliar_Click(object sender, EventArgs e)
		{
			if (num1.Value == num2.Value)
				MessageBox.Show($"{num1.Value} + {num2.Value} = {num1.Value + num2.Value}");
			else
				MessageBox.Show($"{num1.Value} x {num2.Value} = {num1.Value * num2.Value}");
		}
	}
}