namespace Atividade_06
{
	public partial class formMain : Form
	{
		public formMain()
		{
			InitializeComponent();
		}

		private void btnAvaliar_Click(object sender, EventArgs e)
		{
			float lado1 = (float) numLado1.Value,
				 lado2 = (float) numLado2.Value,
				 lado3 = (float) numLado3.Value;

			string typeOfTriangle;

			if (lado1 == lado2 && lado2 == lado3) typeOfTriangle = "Equilatero";
			else if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1) typeOfTriangle = "Escaleno";
			else typeOfTriangle = "Isóceles";

			lblType.Text = $"Tipo de Triângulo: {typeOfTriangle}";
		}
	}
}