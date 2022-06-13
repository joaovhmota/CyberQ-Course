namespace Exemplo_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dgvProdutos.ColumnCount = 3;
			dgvProdutos.ColumnHeadersVisible = true;

			dgvProdutos.Columns[0].Name = "Nome";
			dgvProdutos.Columns[1].Name = "Marca";
			dgvProdutos.Columns[2].Name = "Pre�o";

			dgvProdutos.Rows.Add(new object[] {"Notebooks Gamer", "Dell", "4300"});
			dgvProdutos.Rows.Add(new object[] {"Aerof�lio para P�lio", "Aerof�lio", "14300"});

			for (int i = 0; i < dgvProdutos.ColumnCount; i++)
				dgvProdutos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;

			MessageBox.Show($"{dgvProdutos.Rows[index]}");
		}
	}
}