namespace Exemplo_04_Banco_de_Dados {
     partial class Form1 {
          /// <summary>
          ///  Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          ///  Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing) {
               if ( disposing && ( components != null ) ) {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          ///  Required method for Designer support - do not modify
          ///  the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent() {
               this.txtNomePessoa = new System.Windows.Forms.TextBox();
               this.lblNomePessoa = new System.Windows.Forms.Label();
               this.lblIdadePessoa = new System.Windows.Forms.Label();
               this.numIdadePessoa = new System.Windows.Forms.NumericUpDown();
               this.btnAddPessoa = new System.Windows.Forms.Button();
               this.dgvPessoas = new System.Windows.Forms.DataGridView();
               ((System.ComponentModel.ISupportInitialize)(this.numIdadePessoa)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
               this.SuspendLayout();
               // 
               // txtNomePessoa
               // 
               this.txtNomePessoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.txtNomePessoa.Location = new System.Drawing.Point(93, 16);
               this.txtNomePessoa.Name = "txtNomePessoa";
               this.txtNomePessoa.Size = new System.Drawing.Size(379, 35);
               this.txtNomePessoa.TabIndex = 1;
               // 
               // lblNomePessoa
               // 
               this.lblNomePessoa.AutoSize = true;
               this.lblNomePessoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.lblNomePessoa.Location = new System.Drawing.Point(12, 19);
               this.lblNomePessoa.Name = "lblNomePessoa";
               this.lblNomePessoa.Size = new System.Drawing.Size(75, 30);
               this.lblNomePessoa.TabIndex = 2;
               this.lblNomePessoa.Text = "Nome:";
               // 
               // lblIdadePessoa
               // 
               this.lblIdadePessoa.AutoSize = true;
               this.lblIdadePessoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.lblIdadePessoa.Location = new System.Drawing.Point(12, 60);
               this.lblIdadePessoa.Name = "lblIdadePessoa";
               this.lblIdadePessoa.Size = new System.Drawing.Size(70, 30);
               this.lblIdadePessoa.TabIndex = 4;
               this.lblIdadePessoa.Text = "Idade:";
               // 
               // numIdadePessoa
               // 
               this.numIdadePessoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.numIdadePessoa.Location = new System.Drawing.Point(93, 58);
               this.numIdadePessoa.Name = "numIdadePessoa";
               this.numIdadePessoa.Size = new System.Drawing.Size(379, 35);
               this.numIdadePessoa.TabIndex = 5;
               // 
               // btnAddPessoa
               // 
               this.btnAddPessoa.Location = new System.Drawing.Point(12, 99);
               this.btnAddPessoa.Name = "btnAddPessoa";
               this.btnAddPessoa.Size = new System.Drawing.Size(460, 23);
               this.btnAddPessoa.TabIndex = 6;
               this.btnAddPessoa.Text = "Adicionar Pessoa";
               this.btnAddPessoa.UseVisualStyleBackColor = true;
               this.btnAddPessoa.Click += new System.EventHandler(this.btnAddPessoa_Click);
               // 
               // dgvPessoas
               // 
               this.dgvPessoas.AllowUserToAddRows = false;
               this.dgvPessoas.AllowUserToDeleteRows = false;
               this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvPessoas.Location = new System.Drawing.Point(12, 128);
               this.dgvPessoas.Name = "dgvPessoas";
               this.dgvPessoas.ReadOnly = true;
               this.dgvPessoas.RowTemplate.Height = 25;
               this.dgvPessoas.Size = new System.Drawing.Size(460, 321);
               this.dgvPessoas.TabIndex = 7;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(484, 461);
               this.Controls.Add(this.dgvPessoas);
               this.Controls.Add(this.btnAddPessoa);
               this.Controls.Add(this.numIdadePessoa);
               this.Controls.Add(this.lblIdadePessoa);
               this.Controls.Add(this.lblNomePessoa);
               this.Controls.Add(this.txtNomePessoa);
               this.Name = "Form1";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               ((System.ComponentModel.ISupportInitialize)(this.numIdadePessoa)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private TextBox txtNomePessoa;
          private Label lblNomePessoa;
          private Label lblIdadePessoa;
          private NumericUpDown numIdadePessoa;
          private Button btnAddPessoa;
          private DataGridView dgvPessoas;
     }
}