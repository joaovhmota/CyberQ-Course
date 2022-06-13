namespace Atividade_09
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			dgvConvertion.Rows.Clear();

			dgvConvertion.ColumnCount = 3;
			dgvConvertion.Columns[0].Name = "De";
			dgvConvertion.Columns[1].Name = "Para";
			dgvConvertion.Columns[2].Name = "Valor";

			dgvConvertion.ColumnHeadersVisible = true;

			for (int i =0; i < dgvConvertion.ColumnCount; i++)
				dgvConvertion.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			dgvConvertion.Rows.Clear();

			int selected = cbxPrimaryCurrency.SelectedIndex;
			if (selected == -1) return;

			if (cbxPrimaryCurrency.Items[selected].ToString() == "Real")
			{
				dgvConvertion.Rows.Add(new object[] {"Real", "Dólar", 0.20});
				dgvConvertion.Rows.Add(new object[] {"Real", "Euro",  0.19});
				dgvConvertion.Rows.Add(new object[] {"Real", "Libra", 0.16});
				dgvConvertion.Rows.Add(new object[] {"Real", "Peso Argentino", 23.93});
			}

			else if (cbxPrimaryCurrency.Items[selected].ToString() == "Dólar")
			{
				dgvConvertion.Rows.Add(new object[] {"Dólar", "Real",  5.10});
				dgvConvertion.Rows.Add(new object[] {"Dólar", "Euro",  0.96});
				dgvConvertion.Rows.Add(new object[] {"Dólar", "Libra", 0.82});
				dgvConvertion.Rows.Add(new object[] {"Dólar", "Peso Argentino", 122.30});
			}

			else if (cbxPrimaryCurrency.Items[selected].ToString() == "Euro")
			{
				dgvConvertion.Rows.Add(new object[] {"Euro", "Real",  5.32});
				dgvConvertion.Rows.Add(new object[] {"Euro", "Dólar", 1.04});
				dgvConvertion.Rows.Add(new object[] {"Euro", "Libra", 0.86});
				dgvConvertion.Rows.Add(new object[] {"Euro", "Peso Argentino", 127.66});
			}

			else if (cbxPrimaryCurrency.Items[selected].ToString() == "Libra")
			{
				dgvConvertion.Rows.Add(new object[] {"Libra", "Real", 6.21});
				dgvConvertion.Rows.Add(new object[] {"Libra", "Dólar", 1.22});
				dgvConvertion.Rows.Add(new object[] {"Libra", "Euro", 1.17});
				dgvConvertion.Rows.Add(new object[] {"Libra", "Peso Argentino", 148.80});
			}

			else if (cbxPrimaryCurrency.Items[selected].ToString() == "Peso Argentino")
			{
				dgvConvertion.Rows.Add(new object[] {"Peso Argentino", "Real",  0.042});
				dgvConvertion.Rows.Add(new object[] {"Peso Argentino", "Dólar", 0.0082});
				dgvConvertion.Rows.Add(new object[] {"Peso Argentino", "Euro",  0.0078});
				dgvConvertion.Rows.Add(new object[] {"Peso Argentino", "Libra", 0.0067});
			}
		}
	}
}