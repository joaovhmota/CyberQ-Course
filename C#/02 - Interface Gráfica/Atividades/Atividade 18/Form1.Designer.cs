namespace Atividade_18
{
	partial class FormMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.tbMenu = new System.Windows.Forms.TabControl();
			this.Login = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.imgIcons = new System.Windows.Forms.ImageList(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtAgency = new System.Windows.Forms.TextBox();
			this.Menu = new System.Windows.Forms.TabPage();
			this.btnSair = new System.Windows.Forms.Button();
			this.lblSaldo = new System.Windows.Forms.Label();
			this.lblLogadoComo = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpgSacar = new System.Windows.Forms.TabPage();
			this.btnSacar = new System.Windows.Forms.Button();
			this.numASacar = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.tpgDepositar = new System.Windows.Forms.TabPage();
			this.btnDep = new System.Windows.Forms.Button();
			this.numDep = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.tpgPoupanca = new System.Windows.Forms.TabPage();
			this.lblPoupanca = new System.Windows.Forms.Label();
			this.btnSacPoup = new System.Windows.Forms.Button();
			this.numSacPoup = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDepPoup = new System.Windows.Forms.Button();
			this.numDepPoup = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.tpgEmprestimo = new System.Windows.Forms.TabPage();
			this.tpgExtrato = new System.Windows.Forms.TabPage();
			this.dgvExtrato = new System.Windows.Forms.DataGridView();
			this.btnEmpres = new System.Windows.Forms.Button();
			this.numEmpres = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.tbMenu.SuspendLayout();
			this.Login.SuspendLayout();
			this.Menu.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tpgSacar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numASacar)).BeginInit();
			this.tpgDepositar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDep)).BeginInit();
			this.tpgPoupanca.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSacPoup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDepPoup)).BeginInit();
			this.tpgEmprestimo.SuspendLayout();
			this.tpgExtrato.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvExtrato)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numEmpres)).BeginInit();
			this.SuspendLayout();
			// 
			// tbMenu
			// 
			this.tbMenu.Controls.Add(this.Login);
			this.tbMenu.Controls.Add(this.Menu);
			this.tbMenu.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbMenu.Location = new System.Drawing.Point(12, 12);
			this.tbMenu.Name = "tbMenu";
			this.tbMenu.SelectedIndex = 0;
			this.tbMenu.Size = new System.Drawing.Size(560, 342);
			this.tbMenu.TabIndex = 0;
			this.tbMenu.Click += new System.EventHandler(this.tbMenu_Click);
			// 
			// Login
			// 
			this.Login.Controls.Add(this.button2);
			this.Login.Controls.Add(this.button1);
			this.Login.Controls.Add(this.btnLogin);
			this.Login.Controls.Add(this.txtPassword);
			this.Login.Controls.Add(this.txtAgency);
			this.Login.Location = new System.Drawing.Point(4, 26);
			this.Login.Name = "Login";
			this.Login.Padding = new System.Windows.Forms.Padding(3);
			this.Login.Size = new System.Drawing.Size(552, 312);
			this.Login.TabIndex = 0;
			this.Login.Text = "Login";
			this.Login.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.ImageIndex = 1;
			this.button2.ImageList = this.imgIcons;
			this.button2.Location = new System.Drawing.Point(6, 44);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(32, 32);
			this.button2.TabIndex = 6;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// imgIcons
			// 
			this.imgIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcons.ImageStream")));
			this.imgIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.imgIcons.Images.SetKeyName(0, "User.ico");
			this.imgIcons.Images.SetKeyName(1, "Lock.ico");
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.ImageIndex = 0;
			this.button1.ImageList = this.imgIcons;
			this.button1.Location = new System.Drawing.Point(6, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 32);
			this.button1.TabIndex = 5;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnLogin.Location = new System.Drawing.Point(164, 82);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(85, 32);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Entrar";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPassword.Font = new System.Drawing.Font("Wingdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPassword.Location = new System.Drawing.Point(44, 45);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = 'l';
			this.txtPassword.Size = new System.Drawing.Size(205, 31);
			this.txtPassword.TabIndex = 2;
			// 
			// txtAgency
			// 
			this.txtAgency.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtAgency.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtAgency.Location = new System.Drawing.Point(44, 6);
			this.txtAgency.Name = "txtAgency";
			this.txtAgency.Size = new System.Drawing.Size(205, 32);
			this.txtAgency.TabIndex = 0;
			// 
			// Menu
			// 
			this.Menu.Controls.Add(this.btnSair);
			this.Menu.Controls.Add(this.lblSaldo);
			this.Menu.Controls.Add(this.lblLogadoComo);
			this.Menu.Controls.Add(this.tabControl1);
			this.Menu.Location = new System.Drawing.Point(4, 26);
			this.Menu.Name = "Menu";
			this.Menu.Padding = new System.Windows.Forms.Padding(3);
			this.Menu.Size = new System.Drawing.Size(552, 312);
			this.Menu.TabIndex = 1;
			this.Menu.Text = "Menu";
			this.Menu.UseVisualStyleBackColor = true;
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(471, 6);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 31);
			this.btnSair.TabIndex = 3;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// lblSaldo
			// 
			this.lblSaldo.AutoSize = true;
			this.lblSaldo.Location = new System.Drawing.Point(10, 20);
			this.lblSaldo.Name = "lblSaldo";
			this.lblSaldo.Size = new System.Drawing.Size(64, 17);
			this.lblSaldo.TabIndex = 2;
			this.lblSaldo.Text = "Saldo: ";
			// 
			// lblLogadoComo
			// 
			this.lblLogadoComo.AutoSize = true;
			this.lblLogadoComo.Location = new System.Drawing.Point(10, 3);
			this.lblLogadoComo.Name = "lblLogadoComo";
			this.lblLogadoComo.Size = new System.Drawing.Size(112, 17);
			this.lblLogadoComo.TabIndex = 1;
			this.lblLogadoComo.Text = "Logado como: ";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpgSacar);
			this.tabControl1.Controls.Add(this.tpgDepositar);
			this.tabControl1.Controls.Add(this.tpgPoupanca);
			this.tabControl1.Controls.Add(this.tpgEmprestimo);
			this.tabControl1.Controls.Add(this.tpgExtrato);
			this.tabControl1.Location = new System.Drawing.Point(6, 40);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(540, 266);
			this.tabControl1.TabIndex = 0;
			// 
			// tpgSacar
			// 
			this.tpgSacar.Controls.Add(this.btnSacar);
			this.tpgSacar.Controls.Add(this.numASacar);
			this.tpgSacar.Controls.Add(this.label1);
			this.tpgSacar.Location = new System.Drawing.Point(4, 26);
			this.tpgSacar.Name = "tpgSacar";
			this.tpgSacar.Padding = new System.Windows.Forms.Padding(3);
			this.tpgSacar.Size = new System.Drawing.Size(532, 236);
			this.tpgSacar.TabIndex = 0;
			this.tpgSacar.Text = "Sacar";
			this.tpgSacar.UseVisualStyleBackColor = true;
			// 
			// btnSacar
			// 
			this.btnSacar.Location = new System.Drawing.Point(274, 10);
			this.btnSacar.Name = "btnSacar";
			this.btnSacar.Size = new System.Drawing.Size(87, 23);
			this.btnSacar.TabIndex = 2;
			this.btnSacar.Text = "Sacar";
			this.btnSacar.UseVisualStyleBackColor = true;
			this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
			// 
			// numASacar
			// 
			this.numASacar.Location = new System.Drawing.Point(124, 10);
			this.numASacar.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.numASacar.Name = "numASacar";
			this.numASacar.Size = new System.Drawing.Size(144, 23);
			this.numASacar.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valor a sacar";
			// 
			// tpgDepositar
			// 
			this.tpgDepositar.Controls.Add(this.btnDep);
			this.tpgDepositar.Controls.Add(this.numDep);
			this.tpgDepositar.Controls.Add(this.label2);
			this.tpgDepositar.Location = new System.Drawing.Point(4, 26);
			this.tpgDepositar.Name = "tpgDepositar";
			this.tpgDepositar.Padding = new System.Windows.Forms.Padding(3);
			this.tpgDepositar.Size = new System.Drawing.Size(532, 236);
			this.tpgDepositar.TabIndex = 1;
			this.tpgDepositar.Text = "Depositar";
			this.tpgDepositar.UseVisualStyleBackColor = true;
			// 
			// btnDep
			// 
			this.btnDep.Location = new System.Drawing.Point(306, 9);
			this.btnDep.Name = "btnDep";
			this.btnDep.Size = new System.Drawing.Size(94, 23);
			this.btnDep.TabIndex = 5;
			this.btnDep.Text = "Depositar";
			this.btnDep.UseVisualStyleBackColor = true;
			this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
			// 
			// numDep
			// 
			this.numDep.Location = new System.Drawing.Point(156, 10);
			this.numDep.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.numDep.Name = "numDep";
			this.numDep.Size = new System.Drawing.Size(144, 23);
			this.numDep.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Valor a depositar";
			// 
			// tpgPoupanca
			// 
			this.tpgPoupanca.Controls.Add(this.lblPoupanca);
			this.tpgPoupanca.Controls.Add(this.btnSacPoup);
			this.tpgPoupanca.Controls.Add(this.numSacPoup);
			this.tpgPoupanca.Controls.Add(this.label4);
			this.tpgPoupanca.Controls.Add(this.btnDepPoup);
			this.tpgPoupanca.Controls.Add(this.numDepPoup);
			this.tpgPoupanca.Controls.Add(this.label3);
			this.tpgPoupanca.Location = new System.Drawing.Point(4, 26);
			this.tpgPoupanca.Name = "tpgPoupanca";
			this.tpgPoupanca.Size = new System.Drawing.Size(532, 236);
			this.tpgPoupanca.TabIndex = 2;
			this.tpgPoupanca.Text = "Poupança";
			this.tpgPoupanca.UseVisualStyleBackColor = true;
			// 
			// lblPoupanca
			// 
			this.lblPoupanca.AutoSize = true;
			this.lblPoupanca.Location = new System.Drawing.Point(3, 10);
			this.lblPoupanca.Name = "lblPoupanca";
			this.lblPoupanca.Size = new System.Drawing.Size(112, 17);
			this.lblPoupanca.TabIndex = 12;
			this.lblPoupanca.Text = "Na poupança: ";
			// 
			// btnSacPoup
			// 
			this.btnSacPoup.Location = new System.Drawing.Point(303, 79);
			this.btnSacPoup.Name = "btnSacPoup";
			this.btnSacPoup.Size = new System.Drawing.Size(94, 23);
			this.btnSacPoup.TabIndex = 11;
			this.btnSacPoup.Text = "Sacar";
			this.btnSacPoup.UseVisualStyleBackColor = true;
			this.btnSacPoup.Click += new System.EventHandler(this.btnSacPoup_Click);
			// 
			// numSacPoup
			// 
			this.numSacPoup.Location = new System.Drawing.Point(153, 77);
			this.numSacPoup.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.numSacPoup.Name = "numSacPoup";
			this.numSacPoup.Size = new System.Drawing.Size(144, 23);
			this.numSacPoup.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Valor a sacar";
			// 
			// btnDepPoup
			// 
			this.btnDepPoup.Location = new System.Drawing.Point(303, 45);
			this.btnDepPoup.Name = "btnDepPoup";
			this.btnDepPoup.Size = new System.Drawing.Size(94, 23);
			this.btnDepPoup.TabIndex = 8;
			this.btnDepPoup.Text = "Depositar";
			this.btnDepPoup.UseVisualStyleBackColor = true;
			this.btnDepPoup.Click += new System.EventHandler(this.btnDepPoup_Click);
			// 
			// numDepPoup
			// 
			this.numDepPoup.Location = new System.Drawing.Point(153, 46);
			this.numDepPoup.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.numDepPoup.Name = "numDepPoup";
			this.numDepPoup.Size = new System.Drawing.Size(144, 23);
			this.numDepPoup.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Valor a depositar";
			// 
			// tpgEmprestimo
			// 
			this.tpgEmprestimo.Controls.Add(this.btnEmpres);
			this.tpgEmprestimo.Controls.Add(this.numEmpres);
			this.tpgEmprestimo.Controls.Add(this.label5);
			this.tpgEmprestimo.Location = new System.Drawing.Point(4, 26);
			this.tpgEmprestimo.Name = "tpgEmprestimo";
			this.tpgEmprestimo.Size = new System.Drawing.Size(532, 236);
			this.tpgEmprestimo.TabIndex = 3;
			this.tpgEmprestimo.Text = "Empréstimo";
			this.tpgEmprestimo.UseVisualStyleBackColor = true;
			// 
			// tpgExtrato
			// 
			this.tpgExtrato.Controls.Add(this.dgvExtrato);
			this.tpgExtrato.Location = new System.Drawing.Point(4, 24);
			this.tpgExtrato.Name = "tpgExtrato";
			this.tpgExtrato.Size = new System.Drawing.Size(532, 238);
			this.tpgExtrato.TabIndex = 4;
			this.tpgExtrato.Text = "Extrato";
			this.tpgExtrato.UseVisualStyleBackColor = true;
			// 
			// dgvExtrato
			// 
			this.dgvExtrato.AllowUserToAddRows = false;
			this.dgvExtrato.AllowUserToDeleteRows = false;
			this.dgvExtrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvExtrato.Location = new System.Drawing.Point(3, 3);
			this.dgvExtrato.Name = "dgvExtrato";
			this.dgvExtrato.ReadOnly = true;
			this.dgvExtrato.RowTemplate.Height = 25;
			this.dgvExtrato.Size = new System.Drawing.Size(526, 230);
			this.dgvExtrato.TabIndex = 0;
			// 
			// btnEmpres
			// 
			this.btnEmpres.Location = new System.Drawing.Point(319, 11);
			this.btnEmpres.Name = "btnEmpres";
			this.btnEmpres.Size = new System.Drawing.Size(94, 23);
			this.btnEmpres.TabIndex = 8;
			this.btnEmpres.Text = "Pegar";
			this.btnEmpres.UseVisualStyleBackColor = true;
			this.btnEmpres.Click += new System.EventHandler(this.btnEmpres_Click);
			// 
			// numEmpres
			// 
			this.numEmpres.Location = new System.Drawing.Point(169, 12);
			this.numEmpres.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.numEmpres.Name = "numEmpres";
			this.numEmpres.Size = new System.Drawing.Size(144, 23);
			this.numEmpres.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(160, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Valor do Empréstimo";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 366);
			this.Controls.Add(this.tbMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.tbMenu.ResumeLayout(false);
			this.Login.ResumeLayout(false);
			this.Login.PerformLayout();
			this.Menu.ResumeLayout(false);
			this.Menu.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tpgSacar.ResumeLayout(false);
			this.tpgSacar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numASacar)).EndInit();
			this.tpgDepositar.ResumeLayout(false);
			this.tpgDepositar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDep)).EndInit();
			this.tpgPoupanca.ResumeLayout(false);
			this.tpgPoupanca.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSacPoup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDepPoup)).EndInit();
			this.tpgEmprestimo.ResumeLayout(false);
			this.tpgEmprestimo.PerformLayout();
			this.tpgExtrato.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvExtrato)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numEmpres)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private TabControl tbMenu;
		private TabPage Menu;
		private ImageList imgIcons;
		private TabControl tabControl1;
		private TabPage tpgSacar;
		private TabPage tpgDepositar;
		private TabPage tpgPoupanca;
		private TabPage tpgEmprestimo;
		private TabPage tpgExtrato;
		private TabPage Login;
		private Button button2;
		private Button button1;
		private Button btnLogin;
		private TextBox txtPassword;
		private TextBox txtAgency;
		private Label lblLogadoComo;
		private Label lblSaldo;
		private Button btnSair;
		private Button btnSacar;
		private NumericUpDown numASacar;
		private Label label1;
		private Button btnDep;
		private NumericUpDown numDep;
		private Label label2;
		private DataGridView dgvExtrato;
		private Label lblPoupanca;
		private Button btnSacPoup;
		private NumericUpDown numSacPoup;
		private Label label4;
		private Button btnDepPoup;
		private NumericUpDown numDepPoup;
		private Label label3;
		private Button btnEmpres;
		private NumericUpDown numEmpres;
		private Label label5;
	}
}