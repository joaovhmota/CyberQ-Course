using System;

namespace Atividade_12
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void btnSigno_Click(object sender, EventArgs e)
		{
			DateTime date = dtpDate.Value;

			if ((date.Month == 12 && date.Day >= 22) || (date.Month == 1 && date.Day <= 20))
				txtSigno.Text = "Capricórnio";
			
			if ((date.Month == 1 && date.Day >= 21) || (date.Month == 2 && date.Day <= 18))
				txtSigno.Text = "Aquário";

			if ((date.Month == 2 && date.Day >= 19) || (date.Month == 3 && date.Day <= 20))
				txtSigno.Text = "Peixes";

			if ((date.Month == 3 && date.Day >= 21) || (date.Month == 4 && date.Day <= 20))
				txtSigno.Text = "Áries";

			if ((date.Month == 4 && date.Day >= 21) || (date.Month == 5 && date.Day <= 20))
				txtSigno.Text = "Touro";

			if ((date.Month == 5 && date.Day >= 21) || (date.Month == 6 && date.Day <= 20))
				txtSigno.Text = "Gêmeos";
			
			if ((date.Month == 6 && date.Day >= 21) || (date.Month == 7 && date.Day <= 22))
				txtSigno.Text = "Câncer";

			if ((date.Month == 7 && date.Day >= 23) || (date.Month == 8 && date.Day <= 22))
				txtSigno.Text = "Leão";

			if ((date.Month == 8 && date.Day >= 23) || (date.Month == 9 && date.Day <= 22))
				txtSigno.Text = "Virgem";

			if ((date.Month == 9 && date.Day >= 23) || (date.Month == 10 && date.Day <= 22))
				txtSigno.Text = "Libra";

			if ((date.Month == 10 && date.Day >= 23) || (date.Month == 11 && date.Day <= 21))
				txtSigno.Text = "Escorpião";

			if ((date.Month == 11 && date.Day >= 22) || (date.Month == 12 && date.Day <= 21))
				txtSigno.Text = "Sagitário";

		}
	}
}