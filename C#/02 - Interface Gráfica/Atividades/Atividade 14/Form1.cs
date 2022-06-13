namespace Atividade_14
{
	public partial class FormMain : Form
	{
		int generated;
		int totalCredits;

		public FormMain()
		{
			InitializeComponent();
			generated = new Random().Next(100);
			totalCredits = 10;
			MessageBox.Show("回复: " + generated.ToString());
		}

		private void btnTry_Click(object sender, EventArgs e)
		{
			if (numTry.Value != generated)
			{
				btnImage.ImageIndex = 1;
				totalCredits--;
				progressBar1.Value = totalCredits;

				MessageBox.Show("很近", "", MessageBoxButtons.RetryCancel);

				lblSocial.Text = $"Social Credits: {totalCredits}/10";
			}
			else if (numTry.Value == generated)
			{
				btnImage.ImageIndex = 0;
				progressBar1.Value = 10;
				btnTry.Enabled = false;
			}
			if (progressBar1.Value == 0)
			{
				btnImage.ImageIndex = 2;
				FormMain.ActiveForm.BackColor = Color.Red;
				MessageBox.Show("的笑容 都没你的甜 八月正午的阳光 都没你耀眼 热爱 105 °C的你 滴滴清纯的蒸馏水", "的笑容 都没你的甜 八月正午的阳光 都没你耀眼 热爱 105 °C的你 滴滴清纯的蒸馏水", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
				this.Close();
			}

		}

		private void numTry_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnTry_Click(btnTry, e);
		}
	}
}