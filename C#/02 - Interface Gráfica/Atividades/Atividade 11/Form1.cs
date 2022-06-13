namespace Atividade_11
{
	public partial class FormMain : Form
	{
		bool changed;
		public FormMain()
		{
			InitializeComponent();
			changed = false;
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			if (radioC.Checked)
			{
				float emF = 0.0f;
				float emC = Convert.ToSingle(txtC.Text);
	
				txtF.Text = Convert.ToSingle(emC * 1.8 + 32).ToString();
			}
			else if (radioF.Checked)
			{
				float emF = Convert.ToSingle(txtF.Text);
				float emC = 0.0f;

				txtC.Text = Convert.ToSingle((emF - 32) / 1.8).ToString();
			}
		}
	}
}