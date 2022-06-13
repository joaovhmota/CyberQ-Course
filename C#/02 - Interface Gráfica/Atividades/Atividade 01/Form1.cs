namespace Atividade_01
{
	public partial class formSystem : Form
	{
		public formSystem()
		{
			InitializeComponent();
		}

		private void btnSendProduct_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"O produto: {txtProduct.Text} com 10% de desconto é: {( (double) numProductPrice.Value * 0.9):C2}");
		}
	}
}