namespace Exemplo_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSendName_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Seu nome é: {txtUserName.Text}");
		}

		private void ckbCor_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbCor.Checked)
			{
				Form1.ActiveForm.BackColor = Color.Black;
				lblInsertName.ForeColor = Color.White;
				ckbCor.ForeColor = Color.White;
			}
			else
			{
				Form1.ActiveForm.BackColor = Color.White;
				lblInsertName.ForeColor = Color.Black;
				ckbCor.ForeColor = Color.Black;
			}
		}
	}
}