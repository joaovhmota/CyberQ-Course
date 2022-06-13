namespace Atividade_07
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			float inputNum = (float) num1.Value;

			dgvTabuada.Rows.Clear();

			dgvTabuada.ColumnCount = 4;
			dgvTabuada.Columns[0].Name = "Numero1";
			dgvTabuada.Columns[1].Name = "Operador";
			dgvTabuada.Columns[2].Name = "Numero2";
			dgvTabuada.Columns[3].Name = "Output";

			dgvTabuada.ColumnHeadersVisible = false;

			for (int i =0; i < dgvTabuada.ColumnCount; i++)
				dgvTabuada.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			for (int i = 1; i <= 100; i++)
				dgvTabuada.Rows.Add(new object[] { inputNum, "x", i, (inputNum * i) });
		}
	}
}