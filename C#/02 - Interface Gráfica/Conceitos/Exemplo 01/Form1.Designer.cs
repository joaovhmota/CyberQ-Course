namespace Exemplo_01
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
			this.lblInsertName = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.btnSendName = new System.Windows.Forms.Button();
			this.ckbCor = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lblInsertName
			// 
			this.lblInsertName.AutoSize = true;
			this.lblInsertName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblInsertName.Location = new System.Drawing.Point(12, 9);
			this.lblInsertName.Name = "lblInsertName";
			this.lblInsertName.Size = new System.Drawing.Size(171, 30);
			this.lblInsertName.TabIndex = 0;
			this.lblInsertName.Text = "Insira seu nome: ";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(189, 16);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(599, 23);
			this.txtUserName.TabIndex = 1;
			// 
			// btnSendName
			// 
			this.btnSendName.Location = new System.Drawing.Point(189, 45);
			this.btnSendName.Name = "btnSendName";
			this.btnSendName.Size = new System.Drawing.Size(145, 23);
			this.btnSendName.TabIndex = 2;
			this.btnSendName.Text = "Enviar";
			this.btnSendName.UseVisualStyleBackColor = true;
			this.btnSendName.Click += new System.EventHandler(this.btnSendName_Click);
			// 
			// ckbCor
			// 
			this.ckbCor.AutoSize = true;
			this.ckbCor.Location = new System.Drawing.Point(13, 83);
			this.ckbCor.Name = "ckbCor";
			this.ckbCor.Size = new System.Drawing.Size(81, 19);
			this.ckbCor.TabIndex = 3;
			this.ckbCor.Text = "Alterar cor";
			this.ckbCor.UseVisualStyleBackColor = true;
			this.ckbCor.CheckedChanged += new System.EventHandler(this.ckbCor_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ckbCor);
			this.Controls.Add(this.btnSendName);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblInsertName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblInsertName;
		private TextBox txtUserName;
		private Button btnSendName;
		private CheckBox ckbCor;
	}
}