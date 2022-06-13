namespace Atividade_14
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.numTry = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.lblSocial = new System.Windows.Forms.Label();
			this.btnTry = new System.Windows.Forms.Button();
			this.socialCredits = new System.Windows.Forms.ImageList(this.components);
			this.btnImage = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numTry)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 171);
			this.progressBar1.Maximum = 10;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(776, 23);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 1;
			this.progressBar1.Value = 10;
			// 
			// numTry
			// 
			this.numTry.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.numTry.Location = new System.Drawing.Point(305, 12);
			this.numTry.Name = "numTry";
			this.numTry.Size = new System.Drawing.Size(120, 33);
			this.numTry.TabIndex = 2;
			this.numTry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numTry_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 30);
			this.label1.TabIndex = 3;
			this.label1.Text = "Digite um número de 1 a 100:";
			// 
			// lblSocial
			// 
			this.lblSocial.AutoSize = true;
			this.lblSocial.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblSocial.Location = new System.Drawing.Point(12, 143);
			this.lblSocial.Name = "lblSocial";
			this.lblSocial.Size = new System.Drawing.Size(182, 25);
			this.lblSocial.TabIndex = 4;
			this.lblSocial.Text = "Social Credits: 10/10";
			// 
			// btnTry
			// 
			this.btnTry.Location = new System.Drawing.Point(431, 12);
			this.btnTry.Name = "btnTry";
			this.btnTry.Size = new System.Drawing.Size(96, 33);
			this.btnTry.TabIndex = 5;
			this.btnTry.Text = "Tentar";
			this.btnTry.UseVisualStyleBackColor = true;
			this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
			// 
			// socialCredits
			// 
			this.socialCredits.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.socialCredits.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("socialCredits.ImageStream")));
			this.socialCredits.TransparentColor = System.Drawing.Color.Transparent;
			this.socialCredits.Images.SetKeyName(0, "+InfiniteSocial.jpg");
			this.socialCredits.Images.SetKeyName(1, "-1Social.png");
			this.socialCredits.Images.SetKeyName(2, "Infinite.gif");
			// 
			// btnImage
			// 
			this.btnImage.ImageList = this.socialCredits;
			this.btnImage.Location = new System.Drawing.Point(533, 12);
			this.btnImage.Name = "btnImage";
			this.btnImage.Size = new System.Drawing.Size(255, 153);
			this.btnImage.TabIndex = 6;
			this.btnImage.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 206);
			this.Controls.Add(this.btnImage);
			this.Controls.Add(this.btnTry);
			this.Controls.Add(this.lblSocial);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numTry);
			this.Controls.Add(this.progressBar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			((System.ComponentModel.ISupportInitialize)(this.numTry)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ProgressBar progressBar1;
		private NumericUpDown numTry;
		private Label label1;
		private Label lblSocial;
		private Button btnTry;
		private ImageList socialCredits;
		private Button btnImage;
	}
}