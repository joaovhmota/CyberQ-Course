namespace Atividade_03
{
	public partial class formMain : Form
	{
		public formMain()
		{
			InitializeComponent();
		}

		private void btnNums_Click(object sender, EventArgs e)
		{
			List<float> nums = new List<float>();

			string[] numsString = txtNums.Text.Split(";");

			for (int i = 0; i < numsString.Length; i++)
				nums.Add(Convert.ToSingle(numsString[i]));

			nums.Sort();

			MessageBox.Show($"Maior: {nums[nums.Count - 1]}, Menor: {nums[0]}");
		}
	}
}