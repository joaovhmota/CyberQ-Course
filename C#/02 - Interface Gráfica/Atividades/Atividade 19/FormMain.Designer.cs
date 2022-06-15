namespace Atividade_19
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
			this.imgIcon = new System.Windows.Forms.ImageList(this.components);
			this.dgvDashboard = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnShowProducts = new System.Windows.Forms.Button();
			this.btnShowBrands = new System.Windows.Forms.Button();
			this.btnBrands = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnProducts = new System.Windows.Forms.Button();
			this.imgBaita = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// imgIcon
			// 
			this.imgIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
			this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
			this.imgIcon.Images.SetKeyName(0, "SmugAnya.jpg");
			// 
			// dgvDashboard
			// 
			this.dgvDashboard.AllowUserToAddRows = false;
			this.dgvDashboard.AllowUserToDeleteRows = false;
			this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDashboard.Location = new System.Drawing.Point(6, 22);
			this.dgvDashboard.Name = "dgvDashboard";
			this.dgvDashboard.ReadOnly = true;
			this.dgvDashboard.RowTemplate.Height = 25;
			this.dgvDashboard.Size = new System.Drawing.Size(448, 207);
			this.dgvDashboard.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnShowProducts);
			this.groupBox1.Controls.Add(this.btnShowBrands);
			this.groupBox1.Controls.Add(this.dgvDashboard);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(460, 264);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "DashBoard";
			// 
			// btnShowProducts
			// 
			this.btnShowProducts.Location = new System.Drawing.Point(231, 235);
			this.btnShowProducts.Name = "btnShowProducts";
			this.btnShowProducts.Size = new System.Drawing.Size(217, 23);
			this.btnShowProducts.TabIndex = 2;
			this.btnShowProducts.Text = "Mostrar Produtos";
			this.btnShowProducts.UseVisualStyleBackColor = true;
			this.btnShowProducts.Click += new System.EventHandler(this.btnShowProducts_Click);
			// 
			// btnShowBrands
			// 
			this.btnShowBrands.Location = new System.Drawing.Point(6, 235);
			this.btnShowBrands.Name = "btnShowBrands";
			this.btnShowBrands.Size = new System.Drawing.Size(217, 23);
			this.btnShowBrands.TabIndex = 1;
			this.btnShowBrands.Text = "Mostrar Marcas";
			this.btnShowBrands.UseVisualStyleBackColor = true;
			this.btnShowBrands.Click += new System.EventHandler(this.btnShowBrands_Click);
			// 
			// btnBrands
			// 
			this.btnBrands.Image = ((System.Drawing.Image)(resources.GetObject("btnBrands.Image")));
			this.btnBrands.Location = new System.Drawing.Point(6, 22);
			this.btnBrands.Name = "btnBrands";
			this.btnBrands.Size = new System.Drawing.Size(217, 139);
			this.btnBrands.TabIndex = 2;
			this.btnBrands.UseVisualStyleBackColor = true;
			this.btnBrands.Click += new System.EventHandler(this.btnBrands_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnProducts);
			this.groupBox2.Controls.Add(this.btnBrands);
			this.groupBox2.Location = new System.Drawing.Point(12, 282);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(454, 167);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Forms";
			// 
			// btnProducts
			// 
			this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
			this.btnProducts.Location = new System.Drawing.Point(231, 22);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Size = new System.Drawing.Size(217, 139);
			this.btnProducts.TabIndex = 3;
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// imgBaita
			// 
			this.imgBaita.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgBaita.ImageSize = new System.Drawing.Size(16, 16);
			this.imgBaita.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMain";
			((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private ImageList imgIcon;
		private DataGridView dgvDashboard;
		private GroupBox groupBox1;
		private Button btnBrands;
		private GroupBox groupBox2;
		private Button btnProducts;
		private ImageList imgBaita;
		private Button btnShowProducts;
		private Button btnShowBrands;
	}
}