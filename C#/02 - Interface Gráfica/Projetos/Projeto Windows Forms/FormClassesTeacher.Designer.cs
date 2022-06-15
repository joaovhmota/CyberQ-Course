namespace Projeto_Windows_Forms
{
	partial class FormClassesTeacher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClassesTeacher));
			this.gbxAllClasses = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// gbxAllClasses
			// 
			this.gbxAllClasses.Location = new System.Drawing.Point(12, 12);
			this.gbxAllClasses.Name = "gbxAllClasses";
			this.gbxAllClasses.Size = new System.Drawing.Size(460, 180);
			this.gbxAllClasses.TabIndex = 0;
			this.gbxAllClasses.TabStop = false;
			this.gbxAllClasses.Text = "Lista de Salas de Aula";
			// 
			// FormClassesTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.gbxAllClasses);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormClassesTeacher";
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox gbxAllClasses;
	}
}