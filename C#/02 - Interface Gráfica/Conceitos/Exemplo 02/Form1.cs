namespace Exemplo_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			// cbxNomes.Items.Add("Rei da sinuca");
			// cbxNomes.Items.Add("Samuca");*
			// cbxNomes.Items.Add("Rodrigo Farô");
			// cbxNomes.Items.Add("Adegas");

			Person p1 = new Person("Rei da sinuca", 17);
			Person p2 = new Person("Samuca", 17);
			Person p3 = new Person("Radrigo Faro", 17);
			Person p4 = new Person("Adegas", 19);
			Person p5 = new Person("Henrique", 16);
			Person p6 = new Person("William 5 Galinhas", 20);

			cbxNomes.Items.Add(p1);
			cbxNomes.Items.Add(p2);
			cbxNomes.Items.Add(p3);
			cbxNomes.Items.Add(p4);
			cbxNomes.Items.Add(p5);
			cbxNomes.Items.Add(p6);
		}

		private void cbxNomes_SelectedIndexChanged(object sender, EventArgs e)
		{
			//int index = cbxNomes.SelectedIndex;
			Person pObj = (Person) cbxNomes.SelectedItem;
			txtNome.Text = pObj.Nome;
			txtIdade.Text = pObj.Idade.ToString();
		}
	}
}