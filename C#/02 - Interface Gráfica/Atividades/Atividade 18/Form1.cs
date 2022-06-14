namespace Atividade_18
{
	public partial class FormMain : Form
	{
		List<Client> RegisteredClients;
		Client CurrentLoggedIn = null!;
		public FormMain()
		{
			InitializeComponent();
			RegisteredClients = new List<Client>();
			tbMenu.Controls[1].Enabled = false;

			dgvExtrato.ColumnCount = 3;
			dgvExtrato.Columns[0].Name = "Tipo";
			dgvExtrato.Columns[1].Name = "Valor";
			dgvExtrato.Columns[2].Name = "Data";
		}
		
		private void UpdateMenu()
		{
			tbMenu.Controls[1].Enabled = true;
			lblLogadoComo.Text = $"Logado como: {CurrentLoggedIn.Nome}";
			lblSaldo.Text = $"Saldo: {CurrentLoggedIn.Saldo:C2}";
			lblPoupanca.Text = $"Na poupança: {CurrentLoggedIn.Poupanca:C2}";

			for (int i = 0; i < dgvExtrato.ColumnCount; ++i)
			{
				dgvExtrato.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			RegisteredClients.Clear();
			RegisteredClients.Add(new Client("João", "1234", "1234", "1234", 10000.00f));
			RegisteredClients.Add(new Client("Henrique", "4321", "4321", "4321", 10000.00f));
			RegisteredClients.Add(new Client("William", "1324", "1324", "1324", 10000.00f));
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < RegisteredClients.Count; i++)
				if (RegisteredClients[i].Agencia == txtAgency.Text)
					if (RegisteredClients[i].Senha == txtPassword.Text)
					{
						CurrentLoggedIn = RegisteredClients[i];
						tbMenu.SelectedIndex = 1;
						UpdateMenu();
						break;
					}

			txtAgency.Text = "";
			txtPassword.Text = "";
			if (CurrentLoggedIn == null)
			{
				MessageBox.Show("Informações incorretas", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
			}
		}

		private void tbMenu_Click(object sender, EventArgs e)
		{
			if (CurrentLoggedIn == null && tbMenu.SelectedTab.Name == "Menu")
			{
				tbMenu.SelectedIndex = 0;
				return;
			}
			if (CurrentLoggedIn != null && tbMenu.SelectedTab.Name == "Login")
			{
				tbMenu.SelectedIndex = 1;
				return;
			}
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			CurrentLoggedIn = null!;
			tbMenu.SelectedIndex = 0;
		}

		private void btnSacar_Click(object sender, EventArgs e)
		{
			float toSacar = (float) numASacar.Value;
			if (toSacar < 0 || toSacar > CurrentLoggedIn.Saldo)
				MessageBox.Show("Saldo inválido");
			else
				CurrentLoggedIn.Saldo -= toSacar;

			dgvExtrato.Rows.Add(new object[] {"Saque", $"{toSacar:C2}", $"{DateTime.Now}" });

			numASacar.Value = 0;
			UpdateMenu();

		}

		private void btnDep_Click(object sender, EventArgs e)
		{
			float toDep = (float) numDep.Value;
			if (toDep < 0)
				MessageBox.Show("Saldo inválido");
			else
				CurrentLoggedIn.Saldo += toDep;

			dgvExtrato.Rows.Add(new object[] {"Depósito", $"{toDep:C2}", $"{DateTime.Now}" });

			numDep.Value = 0;
			UpdateMenu();
		}

		private void btnDepPoup_Click(object sender, EventArgs e)
		{
			float toDep = (float) numDepPoup.Value;
			if (toDep < 0)
				MessageBox.Show("Saldo inválido");
			else
				CurrentLoggedIn.Poupanca += toDep;

			dgvExtrato.Rows.Add(new object[] {"Depósito na Poupança", $"{toDep:C2}", $"{DateTime.Now}" });

			numDepPoup.Value = 0;
			UpdateMenu();

		}

		private void btnSacPoup_Click(object sender, EventArgs e)
		{
			float toSacar = (float) numSacPoup.Value;
			if (toSacar < 0 || toSacar > CurrentLoggedIn.Poupanca)
				MessageBox.Show("Saldo inválido");
			else
				CurrentLoggedIn.Poupanca -= toSacar;

			dgvExtrato.Rows.Add(new object[] {"Saque da Poupança", $"{toSacar:C2}", $"{DateTime.Now}" });

			numSacPoup.Value = 0;
			UpdateMenu();
		}

		private void btnEmpres_Click(object sender, EventArgs e)
		{
			float toSacar = (float) numEmpres.Value;
			if (toSacar < 0 || toSacar > CurrentLoggedIn.Saldo * 10)
				MessageBox.Show("Saldo inválido");
			else
				CurrentLoggedIn.Saldo += toSacar;

			dgvExtrato.Rows.Add(new object[] {"Empréstimo", $"{toSacar:C2}", $"{DateTime.Now}" });

			numEmpres.Value = 0;
			UpdateMenu();
		}
	}
}