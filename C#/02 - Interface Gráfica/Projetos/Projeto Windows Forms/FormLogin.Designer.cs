namespace Projeto_Windows_Forms
{
	partial class FormLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.lblLogin = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.ckbShowPass = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// txtLogin
			// 
			this.txtLogin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtLogin.Location = new System.Drawing.Point(94, 8);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(178, 22);
			this.txtLogin.TabIndex = 3;
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblLogin.Location = new System.Drawing.Point(12, 12);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(71, 18);
			this.lblLogin.TabIndex = 2;
			this.lblLogin.Text = "LOGIN:";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPassword.Location = new System.Drawing.Point(94, 36);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(178, 22);
			this.txtPassword.TabIndex = 5;
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblSenha.Location = new System.Drawing.Point(12, 40);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(74, 18);
			this.lblSenha.TabIndex = 4;
			this.lblSenha.Text = "SENHA:";
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(12, 69);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 30);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Entrar";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// ckbShowPass
			// 
			this.ckbShowPass.AutoSize = true;
			this.ckbShowPass.Location = new System.Drawing.Point(170, 69);
			this.ckbShowPass.Name = "ckbShowPass";
			this.ckbShowPass.Size = new System.Drawing.Size(102, 19);
			this.ckbShowPass.TabIndex = 7;
			this.ckbShowPass.Text = "Mostrar Senha";
			this.ckbShowPass.UseVisualStyleBackColor = true;
			this.ckbShowPass.CheckedChanged += new System.EventHandler(this.ckbShowPass_CheckedChanged);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 111);
			this.Controls.Add(this.ckbShowPass);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.lblLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtLogin;
		private Label lblLogin;
		private TextBox txtPassword;
		private Label lblSenha;
		private Button btnLogin;
		private CheckBox ckbShowPass;
	}
}