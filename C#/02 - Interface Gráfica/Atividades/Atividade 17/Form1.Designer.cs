namespace Atividade_17
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
			this.gbxCadastro = new System.Windows.Forms.GroupBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.gbxState = new System.Windows.Forms.GroupBox();
			this.cbxState = new System.Windows.Forms.ComboBox();
			this.gbxGender = new System.Windows.Forms.GroupBox();
			this.radWoman = new System.Windows.Forms.RadioButton();
			this.radMen = new System.Windows.Forms.RadioButton();
			this.txtPersonName = new System.Windows.Forms.TextBox();
			this.numPersonAge = new System.Windows.Forms.NumericUpDown();
			this.lblPersonAge = new System.Windows.Forms.Label();
			this.lblPersonName = new System.Windows.Forms.Label();
			this.dgvRegisteredPerson = new System.Windows.Forms.DataGridView();
			this.dgvStats = new System.Windows.Forms.DataGridView();
			this.imgListFiller = new System.Windows.Forms.ImageList(this.components);
			this.btnNothing = new System.Windows.Forms.Button();
			this.gbxCadastro.SuspendLayout();
			this.gbxState.SuspendLayout();
			this.gbxGender.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPersonAge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredPerson)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxCadastro
			// 
			this.gbxCadastro.Controls.Add(this.btnCadastrar);
			this.gbxCadastro.Controls.Add(this.gbxState);
			this.gbxCadastro.Controls.Add(this.gbxGender);
			this.gbxCadastro.Controls.Add(this.txtPersonName);
			this.gbxCadastro.Controls.Add(this.numPersonAge);
			this.gbxCadastro.Controls.Add(this.lblPersonAge);
			this.gbxCadastro.Controls.Add(this.lblPersonName);
			this.gbxCadastro.Location = new System.Drawing.Point(12, 12);
			this.gbxCadastro.Name = "gbxCadastro";
			this.gbxCadastro.Size = new System.Drawing.Size(368, 178);
			this.gbxCadastro.TabIndex = 0;
			this.gbxCadastro.TabStop = false;
			this.gbxCadastro.Text = "Cadastro";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(6, 145);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(350, 23);
			this.btnCadastrar.TabIndex = 6;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// gbxState
			// 
			this.gbxState.Controls.Add(this.cbxState);
			this.gbxState.Location = new System.Drawing.Point(179, 86);
			this.gbxState.Name = "gbxState";
			this.gbxState.Size = new System.Drawing.Size(183, 53);
			this.gbxState.TabIndex = 5;
			this.gbxState.TabStop = false;
			this.gbxState.Text = "Estado";
			// 
			// cbxState
			// 
			this.cbxState.FormattingEnabled = true;
			this.cbxState.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
			this.cbxState.Location = new System.Drawing.Point(6, 21);
			this.cbxState.Name = "cbxState";
			this.cbxState.Size = new System.Drawing.Size(171, 23);
			this.cbxState.TabIndex = 0;
			// 
			// gbxGender
			// 
			this.gbxGender.Controls.Add(this.radWoman);
			this.gbxGender.Controls.Add(this.radMen);
			this.gbxGender.Location = new System.Drawing.Point(6, 86);
			this.gbxGender.Name = "gbxGender";
			this.gbxGender.Size = new System.Drawing.Size(171, 53);
			this.gbxGender.TabIndex = 4;
			this.gbxGender.TabStop = false;
			this.gbxGender.Text = "Gênero";
			// 
			// radWoman
			// 
			this.radWoman.AutoSize = true;
			this.radWoman.Location = new System.Drawing.Point(92, 22);
			this.radWoman.Name = "radWoman";
			this.radWoman.Size = new System.Drawing.Size(75, 19);
			this.radWoman.TabIndex = 1;
			this.radWoman.Text = "Feminino";
			this.radWoman.UseVisualStyleBackColor = true;
			// 
			// radMen
			// 
			this.radMen.AutoSize = true;
			this.radMen.Checked = true;
			this.radMen.Location = new System.Drawing.Point(6, 22);
			this.radMen.Name = "radMen";
			this.radMen.Size = new System.Drawing.Size(80, 19);
			this.radMen.TabIndex = 0;
			this.radMen.TabStop = true;
			this.radMen.Text = "Masculino";
			this.radMen.UseVisualStyleBackColor = true;
			// 
			// txtPersonName
			// 
			this.txtPersonName.Location = new System.Drawing.Point(68, 21);
			this.txtPersonName.Name = "txtPersonName";
			this.txtPersonName.Size = new System.Drawing.Size(294, 23);
			this.txtPersonName.TabIndex = 3;
			// 
			// numPersonAge
			// 
			this.numPersonAge.Location = new System.Drawing.Point(68, 57);
			this.numPersonAge.Maximum = new decimal(new int[] {
            122,
            0,
            0,
            0});
			this.numPersonAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numPersonAge.Name = "numPersonAge";
			this.numPersonAge.Size = new System.Drawing.Size(294, 23);
			this.numPersonAge.TabIndex = 2;
			this.numPersonAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblPersonAge
			// 
			this.lblPersonAge.AutoSize = true;
			this.lblPersonAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblPersonAge.Location = new System.Drawing.Point(11, 54);
			this.lblPersonAge.Name = "lblPersonAge";
			this.lblPersonAge.Size = new System.Drawing.Size(51, 21);
			this.lblPersonAge.TabIndex = 1;
			this.lblPersonAge.Text = "Idade:";
			// 
			// lblPersonName
			// 
			this.lblPersonName.AutoSize = true;
			this.lblPersonName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblPersonName.Location = new System.Drawing.Point(6, 19);
			this.lblPersonName.Name = "lblPersonName";
			this.lblPersonName.Size = new System.Drawing.Size(56, 21);
			this.lblPersonName.TabIndex = 0;
			this.lblPersonName.Text = "Nome:";
			// 
			// dgvRegisteredPerson
			// 
			this.dgvRegisteredPerson.AllowUserToAddRows = false;
			this.dgvRegisteredPerson.AllowUserToDeleteRows = false;
			this.dgvRegisteredPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRegisteredPerson.Location = new System.Drawing.Point(386, 12);
			this.dgvRegisteredPerson.Name = "dgvRegisteredPerson";
			this.dgvRegisteredPerson.ReadOnly = true;
			this.dgvRegisteredPerson.RowTemplate.Height = 25;
			this.dgvRegisteredPerson.Size = new System.Drawing.Size(402, 178);
			this.dgvRegisteredPerson.TabIndex = 1;
			// 
			// dgvStats
			// 
			this.dgvStats.AllowUserToAddRows = false;
			this.dgvStats.AllowUserToDeleteRows = false;
			this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStats.Location = new System.Drawing.Point(386, 196);
			this.dgvStats.Name = "dgvStats";
			this.dgvStats.ReadOnly = true;
			this.dgvStats.RowTemplate.Height = 25;
			this.dgvStats.Size = new System.Drawing.Size(402, 187);
			this.dgvStats.TabIndex = 2;
			// 
			// imgListFiller
			// 
			this.imgListFiller.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgListFiller.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListFiller.ImageStream")));
			this.imgListFiller.TransparentColor = System.Drawing.Color.Transparent;
			this.imgListFiller.Images.SetKeyName(0, "objectIcon.ico");
			// 
			// btnNothing
			// 
			this.btnNothing.BackColor = System.Drawing.Color.Transparent;
			this.btnNothing.ImageIndex = 0;
			this.btnNothing.ImageList = this.imgListFiller;
			this.btnNothing.Location = new System.Drawing.Point(12, 196);
			this.btnNothing.Name = "btnNothing";
			this.btnNothing.Size = new System.Drawing.Size(368, 187);
			this.btnNothing.TabIndex = 3;
			this.btnNothing.UseVisualStyleBackColor = false;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 395);
			this.Controls.Add(this.btnNothing);
			this.Controls.Add(this.dgvStats);
			this.Controls.Add(this.dgvRegisteredPerson);
			this.Controls.Add(this.gbxCadastro);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.gbxCadastro.ResumeLayout(false);
			this.gbxCadastro.PerformLayout();
			this.gbxState.ResumeLayout(false);
			this.gbxGender.ResumeLayout(false);
			this.gbxGender.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPersonAge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredPerson)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox gbxCadastro;
		private TextBox txtPersonName;
		private NumericUpDown numPersonAge;
		private Label lblPersonAge;
		private Label lblPersonName;
		private Button btnCadastrar;
		private GroupBox gbxState;
		private ComboBox cbxState;
		private GroupBox gbxGender;
		private RadioButton radWoman;
		private RadioButton radMen;
		private DataGridView dgvRegisteredPerson;
		private DataGridView dgvStats;
		private ImageList imgListFiller;
		private Button btnNothing;
	}
}