using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_19
{
	public partial class FormBrand : Form
	{
		
		public FormBrand()
		{
			InitializeComponent();
			UpdateDataGrid();
		}

		private void UpdateDataGrid()
		{
			dgvBrands.Rows.Clear();

			dgvBrands.ColumnCount = 1;
			dgvBrands.Columns[0].Name = "Nome da Marca";

			for (int i = 0; i < dgvBrands.ColumnCount; i++)
				dgvBrands.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			for (int i = 0; i < FormMain.Brands.Count; i++)
				dgvBrands.Rows.Add(new object[] {FormMain.Brands[i].Name});
		}

		private void FormBrand_Click(object sender, EventArgs e)
		{
			if (dgvBrands.SelectedRows.Count == 0)
			{
				btnRemoveBrand.Enabled = false;
				btnUpdateBrand.Enabled = false;
			}
		}

		private void btnAddBrand_Click(object sender, EventArgs e)
		{
			if (txtNomeBrand.Text.Trim() == "") return;

			for (int i = 0; i < FormMain.Brands.Count; i++)
				if (FormMain.Brands[i].Name == txtNomeBrand.Text.Trim())
					return;

			FormMain.Brands.Add(new Brand(txtNomeBrand.Text));
			txtNomeBrand.AutoCompleteCustomSource.Add(txtNomeBrand.Text);

			UpdateDataGrid();

			txtNomeBrand.Text = "";
		}

		private void dgvBrands_Click(object sender, EventArgs e)
		{
			if (dgvBrands.SelectedRows.Count > 0)
			{
				btnRemoveBrand.Enabled = true;
				btnUpdateBrand.Enabled = true;

				txtNomeBrand.Text = dgvBrands.Rows[dgvBrands.CurrentCell.RowIndex].Cells[dgvBrands.CurrentCell.ColumnIndex].Value.ToString();
			}
		}

		private void btnRemoveBrand_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < FormMain.Brands.Count; i++)
				if (FormMain.Brands[i].Name == dgvBrands.Rows[dgvBrands.CurrentCell.RowIndex].Cells[dgvBrands.CurrentCell.ColumnIndex].Value.ToString())
					FormMain.Brands.Remove(FormMain.Brands[i]);
			dgvBrands.Rows.Remove(dgvBrands.Rows[dgvBrands.CurrentCell.RowIndex]);
			txtNomeBrand.Text = "";
		}

		private void btnUpdateBrand_Click(object sender, EventArgs e)
		{
			if (txtNomeBrand.Text.Trim() == "") return;

			for (int i = 0; i < FormMain.Brands.Count; i++)
				if (FormMain.Brands[i].Name == dgvBrands.Rows[dgvBrands.CurrentCell.RowIndex].Cells[dgvBrands.CurrentCell.ColumnIndex].Value.ToString())
					FormMain.Brands[i].Name = txtNomeBrand.Text;

			UpdateDataGrid();
		}
	}
}
