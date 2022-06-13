namespace Atividade_08
{
	public partial class FormMain : Form
	{
		bool firstLoad;
		public FormMain()
		{
			InitializeComponent();
			firstLoad = true;
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			dgvCoins.Rows.Clear();
			dgvCoins.Rows.Add(new object[] {0.01f, 0});
			dgvCoins.Rows.Add(new object[] {0.05f, 0});
			dgvCoins.Rows.Add(new object[] {0.10f, 0});
			dgvCoins.Rows.Add(new object[] {0.25f, 0});
			dgvCoins.Rows.Add(new object[] {0.50f, 0});
			dgvCoins.Rows.Add(new object[] {1.00f, 0});
			firstLoad = false;
		}

		private void dgvCoins_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (firstLoad) return;

			float totalValue = 0.0f;

			for (int i = 0; i < dgvCoins.RowCount; i++)
				totalValue += Convert.ToSingle(dgvCoins.Rows[i].Cells[0].Value.ToString()) * Convert.ToSingle(dgvCoins.Rows[i].Cells[1].Value.ToString());

			lblValorTotal.Text = $"Valor total: {totalValue:C2}";
		}
	}
}