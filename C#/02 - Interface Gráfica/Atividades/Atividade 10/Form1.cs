namespace Atividade_10
{
	public partial class Form1 : Form
	{
		int total;

		public Form1()
		{
			InitializeComponent();
			total = 0;
			progressBarNotas.Visible = true;
			progressBarNotas.Enabled = true;
		}

		private new void Update()
		{
			if (total < 0) total = 0;
			progressBarNotas.Value = total;
			lblTotal.Text = $"Total : {total:C2}";
		}

		private void btnNota1_Click(object sender, EventArgs e)
		{
			if (radioSomar.Checked) total += 1;
			if (radioSubtrair.Checked) total -= 1;
			Update();
		}

		private void btnNota2_Click(object sender, EventArgs e)
		{
			if (radioSomar.Checked) total += 2;
			if (radioSubtrair.Checked) total -= 2;
			Update();
		}

		private void btnNota5_Click(object sender, EventArgs e)
		{
			if (radioSomar.Checked) total += 5;
			if (radioSubtrair.Checked) total -= 5;
			Update();
		}

		private void btnNota10_Click(object sender, EventArgs e)
		{
			if (radioSomar.Checked) total += 10;
			if (radioSubtrair.Checked) total += 10;
			Update();
		}

		private void btnNota20_Click(object sender, EventArgs e)
		{
			if (radioSomar.Checked) total += 20;
			if (radioSubtrair.Checked) total -= 20;
			Update();
		}

		private void btnNota50_Click(object sender, EventArgs e)
		{
			if (radioSomar.Checked) total += 50;
			if (radioSubtrair.Checked) total -= 50;
			Update();
		}

		private void btnNota100_Click(object sender, EventArgs e)
		{
			if (radioSomar.Checked) total += 100;
			if (radioSubtrair.Checked) total -= 100;
			Update();
		}

		private void btnNota200_Click(object sender, EventArgs e)
		{
			if (radioSomar.Checked) total += 200;
			if (radioSubtrair.Checked) total -= 200;
			Update();
		}
	}
}