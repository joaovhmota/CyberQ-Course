namespace Atividade_13
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			float km, m;

			if (radioM.Checked)
			{
				m = Convert.ToSingle(txtM.Text);
				km = m / 1000;
				txtKm.Text = Convert.ToString(km);
			}
			else if (radioKm.Checked)
			{
				km = Convert.ToSingle(txtKm.Text);
				m = km * 1000;
				txtKm.Text = Convert.ToString(m);
			}
		}
	}
}