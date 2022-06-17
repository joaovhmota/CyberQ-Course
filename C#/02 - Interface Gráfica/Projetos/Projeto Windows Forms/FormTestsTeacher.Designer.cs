namespace Projeto_Windows_Forms
{
	partial class FormTestsTeacher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestsTeacher));
			this.gbxRegisterTests = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// gbxRegisterTests
			// 
			this.gbxRegisterTests.Location = new System.Drawing.Point(12, 12);
			this.gbxRegisterTests.Name = "gbxRegisterTests";
			this.gbxRegisterTests.Size = new System.Drawing.Size(452, 487);
			this.gbxRegisterTests.TabIndex = 0;
			this.gbxRegisterTests.TabStop = false;
			this.gbxRegisterTests.Text = "groupBox1";
			// 
			// FormTestsTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 511);
			this.Controls.Add(this.gbxRegisterTests);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormTestsTeacher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FormTestsTeacher_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox gbxRegisterTests;
	}
}