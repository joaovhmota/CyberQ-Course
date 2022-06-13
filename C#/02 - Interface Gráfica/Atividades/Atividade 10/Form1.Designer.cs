namespace Atividade_10
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnNota1 = new System.Windows.Forms.Button();
			this.imgListNotas = new System.Windows.Forms.ImageList(this.components);
			this.btnNota2 = new System.Windows.Forms.Button();
			this.btnNota5 = new System.Windows.Forms.Button();
			this.btnNota10 = new System.Windows.Forms.Button();
			this.btnNota20 = new System.Windows.Forms.Button();
			this.btnNota50 = new System.Windows.Forms.Button();
			this.btnNota100 = new System.Windows.Forms.Button();
			this.btnNota200 = new System.Windows.Forms.Button();
			this.gbxNotas = new System.Windows.Forms.GroupBox();
			this.gbxTipo = new System.Windows.Forms.GroupBox();
			this.radioSubtrair = new System.Windows.Forms.RadioButton();
			this.radioSomar = new System.Windows.Forms.RadioButton();
			this.lblTotal = new System.Windows.Forms.Label();
			this.progressBarNotas = new System.Windows.Forms.ProgressBar();
			this.gbxNotas.SuspendLayout();
			this.gbxTipo.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnNota1
			// 
			this.btnNota1.ImageIndex = 0;
			this.btnNota1.ImageList = this.imgListNotas;
			this.btnNota1.Location = new System.Drawing.Point(6, 22);
			this.btnNota1.Name = "btnNota1";
			this.btnNota1.Size = new System.Drawing.Size(250, 100);
			this.btnNota1.TabIndex = 0;
			this.btnNota1.UseVisualStyleBackColor = true;
			this.btnNota1.Click += new System.EventHandler(this.btnNota1_Click);
			// 
			// imgListNotas
			// 
			this.imgListNotas.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgListNotas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListNotas.ImageStream")));
			this.imgListNotas.TransparentColor = System.Drawing.Color.Transparent;
			this.imgListNotas.Images.SetKeyName(0, "Nota1.jpg");
			this.imgListNotas.Images.SetKeyName(1, "Nota2.jpg");
			this.imgListNotas.Images.SetKeyName(2, "Nota5.jpg");
			this.imgListNotas.Images.SetKeyName(3, "Nota10.jpg");
			this.imgListNotas.Images.SetKeyName(4, "Nota20.jpg");
			this.imgListNotas.Images.SetKeyName(5, "Nota50.jpg");
			this.imgListNotas.Images.SetKeyName(6, "Nota100.jpg");
			this.imgListNotas.Images.SetKeyName(7, "Nota200.jpg");
			// 
			// btnNota2
			// 
			this.btnNota2.ImageIndex = 1;
			this.btnNota2.ImageList = this.imgListNotas;
			this.btnNota2.Location = new System.Drawing.Point(262, 22);
			this.btnNota2.Name = "btnNota2";
			this.btnNota2.Size = new System.Drawing.Size(250, 100);
			this.btnNota2.TabIndex = 1;
			this.btnNota2.UseVisualStyleBackColor = true;
			this.btnNota2.Click += new System.EventHandler(this.btnNota2_Click);
			// 
			// btnNota5
			// 
			this.btnNota5.ImageIndex = 2;
			this.btnNota5.ImageList = this.imgListNotas;
			this.btnNota5.Location = new System.Drawing.Point(518, 22);
			this.btnNota5.Name = "btnNota5";
			this.btnNota5.Size = new System.Drawing.Size(250, 100);
			this.btnNota5.TabIndex = 2;
			this.btnNota5.UseVisualStyleBackColor = true;
			this.btnNota5.Click += new System.EventHandler(this.btnNota5_Click);
			// 
			// btnNota10
			// 
			this.btnNota10.ImageIndex = 3;
			this.btnNota10.ImageList = this.imgListNotas;
			this.btnNota10.Location = new System.Drawing.Point(774, 22);
			this.btnNota10.Name = "btnNota10";
			this.btnNota10.Size = new System.Drawing.Size(250, 100);
			this.btnNota10.TabIndex = 3;
			this.btnNota10.UseVisualStyleBackColor = true;
			this.btnNota10.Click += new System.EventHandler(this.btnNota10_Click);
			// 
			// btnNota20
			// 
			this.btnNota20.ImageIndex = 4;
			this.btnNota20.ImageList = this.imgListNotas;
			this.btnNota20.Location = new System.Drawing.Point(6, 128);
			this.btnNota20.Name = "btnNota20";
			this.btnNota20.Size = new System.Drawing.Size(250, 100);
			this.btnNota20.TabIndex = 4;
			this.btnNota20.UseVisualStyleBackColor = true;
			this.btnNota20.Click += new System.EventHandler(this.btnNota20_Click);
			// 
			// btnNota50
			// 
			this.btnNota50.ImageIndex = 5;
			this.btnNota50.ImageList = this.imgListNotas;
			this.btnNota50.Location = new System.Drawing.Point(262, 128);
			this.btnNota50.Name = "btnNota50";
			this.btnNota50.Size = new System.Drawing.Size(250, 100);
			this.btnNota50.TabIndex = 5;
			this.btnNota50.UseVisualStyleBackColor = true;
			this.btnNota50.Click += new System.EventHandler(this.btnNota50_Click);
			// 
			// btnNota100
			// 
			this.btnNota100.ImageIndex = 6;
			this.btnNota100.ImageList = this.imgListNotas;
			this.btnNota100.Location = new System.Drawing.Point(518, 128);
			this.btnNota100.Name = "btnNota100";
			this.btnNota100.Size = new System.Drawing.Size(250, 100);
			this.btnNota100.TabIndex = 6;
			this.btnNota100.UseVisualStyleBackColor = true;
			this.btnNota100.Click += new System.EventHandler(this.btnNota100_Click);
			// 
			// btnNota200
			// 
			this.btnNota200.ImageIndex = 7;
			this.btnNota200.ImageList = this.imgListNotas;
			this.btnNota200.Location = new System.Drawing.Point(774, 128);
			this.btnNota200.Name = "btnNota200";
			this.btnNota200.Size = new System.Drawing.Size(250, 100);
			this.btnNota200.TabIndex = 7;
			this.btnNota200.UseVisualStyleBackColor = true;
			this.btnNota200.Click += new System.EventHandler(this.btnNota200_Click);
			// 
			// gbxNotas
			// 
			this.gbxNotas.Controls.Add(this.btnNota1);
			this.gbxNotas.Controls.Add(this.btnNota200);
			this.gbxNotas.Controls.Add(this.btnNota2);
			this.gbxNotas.Controls.Add(this.btnNota100);
			this.gbxNotas.Controls.Add(this.btnNota5);
			this.gbxNotas.Controls.Add(this.btnNota50);
			this.gbxNotas.Controls.Add(this.btnNota10);
			this.gbxNotas.Controls.Add(this.btnNota20);
			this.gbxNotas.Location = new System.Drawing.Point(12, 12);
			this.gbxNotas.Name = "gbxNotas";
			this.gbxNotas.Size = new System.Drawing.Size(1036, 236);
			this.gbxNotas.TabIndex = 8;
			this.gbxNotas.TabStop = false;
			this.gbxNotas.Text = "Notas";
			// 
			// gbxTipo
			// 
			this.gbxTipo.Controls.Add(this.radioSubtrair);
			this.gbxTipo.Controls.Add(this.radioSomar);
			this.gbxTipo.Location = new System.Drawing.Point(12, 254);
			this.gbxTipo.Name = "gbxTipo";
			this.gbxTipo.Size = new System.Drawing.Size(140, 49);
			this.gbxTipo.TabIndex = 9;
			this.gbxTipo.TabStop = false;
			this.gbxTipo.Text = "Tipo de Ação";
			// 
			// radioSubtrair
			// 
			this.radioSubtrair.AutoSize = true;
			this.radioSubtrair.Location = new System.Drawing.Point(71, 22);
			this.radioSubtrair.Name = "radioSubtrair";
			this.radioSubtrair.Size = new System.Drawing.Size(66, 19);
			this.radioSubtrair.TabIndex = 1;
			this.radioSubtrair.Text = "Subtrair";
			this.radioSubtrair.UseVisualStyleBackColor = true;
			// 
			// radioSomar
			// 
			this.radioSomar.AutoSize = true;
			this.radioSomar.Checked = true;
			this.radioSomar.Location = new System.Drawing.Point(6, 22);
			this.radioSomar.Name = "radioSomar";
			this.radioSomar.Size = new System.Drawing.Size(59, 19);
			this.radioSomar.TabIndex = 0;
			this.radioSomar.TabStop = true;
			this.radioSomar.Text = "Somar";
			this.radioSomar.UseVisualStyleBackColor = true;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTotal.Location = new System.Drawing.Point(157, 271);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(162, 32);
			this.lblTotal.TabIndex = 10;
			this.lblTotal.Text = "Total : R$ 0.00";
			// 
			// progressBarNotas
			// 
			this.progressBarNotas.Location = new System.Drawing.Point(12, 310);
			this.progressBarNotas.MarqueeAnimationSpeed = 1000;
			this.progressBarNotas.Maximum = 2147483647;
			this.progressBarNotas.Minimum = 1;
			this.progressBarNotas.Name = "progressBarNotas";
			this.progressBarNotas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.progressBarNotas.Size = new System.Drawing.Size(1036, 21);
			this.progressBarNotas.Step = 1;
			this.progressBarNotas.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarNotas.TabIndex = 11;
			this.progressBarNotas.Value = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1059, 343);
			this.Controls.Add(this.progressBarNotas);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.gbxTipo);
			this.Controls.Add(this.gbxNotas);
			this.Name = "Form1";
			this.Text = "Form1";
			this.gbxNotas.ResumeLayout(false);
			this.gbxTipo.ResumeLayout(false);
			this.gbxTipo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnNota1;
		private Button btnNota2;
		private Button btnNota5;
		private Button btnNota10;
		private Button btnNota20;
		private Button btnNota50;
		private Button btnNota100;
		private Button btnNota200;
		private ImageList imgListNotas;
		private GroupBox gbxNotas;
		private GroupBox gbxTipo;
		private RadioButton radioSubtrair;
		private RadioButton radioSomar;
		private Label lblTotal;
		private ProgressBar progressBarNotas;
	}
}