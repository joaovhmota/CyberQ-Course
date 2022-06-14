namespace Atividade_19
{
	public partial class FormMain : Form
	{
		public static List<Brand> Brands { get; set; }

		public FormMain()
		{
			InitializeComponent();
			Brands = new();
		}

		private void btnBrands_Click(object sender, EventArgs e)
		{
			FormBrand formBrand = new FormBrand();
			formBrand.ShowDialog();
		}

		private void btnProducts_Click(object sender, EventArgs e)
		{

		}
	}
}