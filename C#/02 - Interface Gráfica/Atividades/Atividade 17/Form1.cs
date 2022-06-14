namespace Atividade_17
{
	public partial class FormMain : Form
	{
		List<Person> RegisteredPeople;
		float AmountMan, 
		    AmountWoman;
		float ManPercent,
			 WomanPercent;
		Person OldestPerson,
			  NewestPerson;

		public FormMain()
		{
			InitializeComponent();
			RegisteredPeople = new List<Person>();
			AmountMan = 0;
			AmountWoman = 0;
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			txtPersonName.Text = "";
			radMen.Checked = true;
			radWoman.Checked = false;
		}

		private void UpdateTables()
		{
			dgvRegisteredPerson.Rows.Clear();
			dgvStats.Rows.Clear();

			dgvRegisteredPerson.ColumnCount = 4;
			dgvRegisteredPerson.Columns[0].Name = "Nome";
			dgvRegisteredPerson.Columns[1].Name = "Idade";
			dgvRegisteredPerson.Columns[2].Name = "Estado";
			dgvRegisteredPerson.Columns[3].Name = "Gênero";

			dgvStats.ColumnCount = 2;
			dgvStats.Columns[0].Name = "Stats";
			dgvStats.Columns[1].Name = "Value";

			dgvStats.ColumnHeadersVisible = false;

			for (int i = 0; i < dgvStats.ColumnCount; i++)
				dgvStats.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			for (int i = 0; i < dgvRegisteredPerson.ColumnCount; i++)
				dgvRegisteredPerson.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


			for (int i = 0; i < RegisteredPeople.Count; i++)
				dgvRegisteredPerson.Rows.Add(new object[] {RegisteredPeople[i].Name, RegisteredPeople[i].Age, RegisteredPeople[i].State, RegisteredPeople[i].Gender});


			OldestPerson = new Person("", 0, "", "");
			NewestPerson = new Person("", 999, "", "");
			AmountMan = 0;
			AmountWoman = 0;

			foreach (Person p in RegisteredPeople)
			{
				if (p.Age > OldestPerson.Age) OldestPerson = p;
				if (p.Age < NewestPerson.Age) NewestPerson = p;

				if (p.Gender == "Homem") AmountMan++;
				if (p.Gender == "Mulher") AmountWoman++;
			}

			ManPercent = (AmountMan / RegisteredPeople.Count);
			WomanPercent = (AmountWoman / RegisteredPeople.Count);

			dgvStats.Rows.Add(new object[] {"Total de Cadastros: ", RegisteredPeople.Count});
			dgvStats.Rows.Add(new object[] {"Total de Homens: ", AmountMan});
			dgvStats.Rows.Add(new object[] {"Total de Mulheres: ", AmountWoman});
			dgvStats.Rows.Add(new object[] {"Percentual de Homens: ", ManPercent.ToString("P2") });
			dgvStats.Rows.Add(new object[] {"Percentual de Mulheres: ", WomanPercent.ToString("P2") });
			dgvStats.Rows.Add(new object[] {"Pessoa mais velha: ", OldestPerson.Name});
			dgvStats.Rows.Add(new object[] {"Pessoa mais nova: ", NewestPerson.Name});

		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
				Person p;
	
				if (txtPersonName.Text.Trim() == "" || cbxState.SelectedIndex == 0) return;
				string name   = txtPersonName.Text;
				int    age    = (int) numPersonAge.Value;
				string state  = (string) cbxState.Items[cbxState.SelectedIndex];
				string gender = ""!;

				if (radMen.Checked) gender = "Homem";
				if (radWoman.Checked) gender = "Mulher";
	
				p = new Person(name, age, state, gender);
				if (!RegisteredPeople.Contains(p)) RegisteredPeople.Add(p);

				UpdateTables();

			} catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning); }
		}
	}
}