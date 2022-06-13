namespace Atividade_05
{
	public partial class formMain : Form
	{
		public formMain()
		{
			InitializeComponent();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			string productName   = txtProductName.Text;
			float  productPrice  = (float) numProductPrice.Value;
			string typeOfPayment = "";
			bool   hasDiscount = false;

			if (radioPrazo.Checked) typeOfPayment = "PRAZO";
			if (radioVista.Checked) typeOfPayment = "VISTA";

			if (typeOfPayment == "VISTA" && productPrice >= 500) hasDiscount = true;

			if (hasDiscount) productPrice *= 0.90f;

			MessageBox.Show($"O valor final do produto {productName} é de: {productPrice:C2}");
		}
	}
}