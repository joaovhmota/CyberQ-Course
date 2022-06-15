namespace Atividade_19
{
	public partial class FormMain : Form
	{
		public static List<Brand> Brands { get; set; }
		public static List<Product> Products { get; set; }

		public FormMain()
		{
			InitializeComponent();
			Brands = new();
			Products = new();
		}

		private void btnBrands_Click(object sender, EventArgs e)
		{
			FormBrand formBrand = new FormBrand();
			formBrand.ShowDialog();
		}

		private void btnProducts_Click(object sender, EventArgs e)
		{
			FormProduct formProduct = new FormProduct();
			formProduct.ShowDialog();
		}

		private void btnShowBrands_Click(object sender, EventArgs e)
		{
			dgvDashboard.Columns.Clear();
			dgvDashboard.Rows.Clear();

			dgvDashboard.ColumnCount = 1;
			dgvDashboard.Columns[0].Name = "Nome marca";

			for (int i = 0; i < Brands.Count; ++i)
				dgvDashboard.Rows.Add(new object[] {Brands[i].Name});

			for (int i = 0; i < dgvDashboard.ColumnCount; ++i)
				dgvDashboard.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void btnShowProducts_Click(object sender, EventArgs e)
		{
			dgvDashboard.Columns.Clear();
			dgvDashboard.Rows.Clear();

			dgvDashboard.ColumnCount = 3;
			dgvDashboard.Columns[0].Name = "Nome do Produto";
			dgvDashboard.Columns[1].Name = "Valor do Produto";
			dgvDashboard.Columns[2].Name = "Marca do Produto";

			for (int i = 0; i < Brands.Count; ++i)
				dgvDashboard.Rows.Add(new object[] {Products[i].Name, Products[i].Price.ToString("C2"), Products[i].Brand.Name});

			for (int i = 0; i < dgvDashboard.ColumnCount; ++i)
				dgvDashboard.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}
	}
}