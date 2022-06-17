namespace Projeto_Windows_Forms
{
	partial class FormBlockerStudentsTeacher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlockerStudentsTeacher));
			this.gbxBlockedAccounts = new System.Windows.Forms.GroupBox();
			this.btnUnblockAccount = new System.Windows.Forms.Button();
			this.dgvBlockedAccounts = new System.Windows.Forms.DataGridView();
			this.gbxBlockedAccounts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBlockedAccounts)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxBlockedAccounts
			// 
			this.gbxBlockedAccounts.Controls.Add(this.btnUnblockAccount);
			this.gbxBlockedAccounts.Controls.Add(this.dgvBlockedAccounts);
			this.gbxBlockedAccounts.Location = new System.Drawing.Point(12, 12);
			this.gbxBlockedAccounts.Name = "gbxBlockedAccounts";
			this.gbxBlockedAccounts.Size = new System.Drawing.Size(360, 337);
			this.gbxBlockedAccounts.TabIndex = 0;
			this.gbxBlockedAccounts.TabStop = false;
			this.gbxBlockedAccounts.Text = "Contas bloqueadas";
			// 
			// btnUnblockAccount
			// 
			this.btnUnblockAccount.Location = new System.Drawing.Point(6, 266);
			this.btnUnblockAccount.Name = "btnUnblockAccount";
			this.btnUnblockAccount.Size = new System.Drawing.Size(348, 65);
			this.btnUnblockAccount.TabIndex = 1;
			this.btnUnblockAccount.Text = "Desbloquear conta";
			this.btnUnblockAccount.UseVisualStyleBackColor = true;
			this.btnUnblockAccount.Click += new System.EventHandler(this.btnUnblockAccount_Click);
			// 
			// dgvBlockedAccounts
			// 
			this.dgvBlockedAccounts.AllowUserToAddRows = false;
			this.dgvBlockedAccounts.AllowUserToDeleteRows = false;
			this.dgvBlockedAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBlockedAccounts.Location = new System.Drawing.Point(6, 22);
			this.dgvBlockedAccounts.Name = "dgvBlockedAccounts";
			this.dgvBlockedAccounts.ReadOnly = true;
			this.dgvBlockedAccounts.RowTemplate.Height = 25;
			this.dgvBlockedAccounts.Size = new System.Drawing.Size(348, 238);
			this.dgvBlockedAccounts.TabIndex = 0;
			// 
			// FormBlockerStudentsTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.gbxBlockedAccounts);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormBlockerStudentsTeacher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FormBlockerStudentsTeacher_Load);
			this.gbxBlockedAccounts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBlockedAccounts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox gbxBlockedAccounts;
		private Button btnUnblockAccount;
		private DataGridView dgvBlockedAccounts;
	}
}