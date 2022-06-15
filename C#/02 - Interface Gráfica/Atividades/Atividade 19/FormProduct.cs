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
	public partial class FormProduct : Form
	{
		public FormProduct()
		{
			InitializeComponent();
			UpdateDataGrid();
		}

		private void UpdateDataGrid()
		{
			cbxBrands.AutoCompleteCustomSource.Clear();
			cbxBrands.Items.Clear();

			for (int i = 0; i < FormMain.Brands.Count; ++i)
			{
				cbxBrands.AutoCompleteCustomSource.Add(FormMain.Brands[i].Name);
				cbxBrands.Items.Add(FormMain.Brands[i].Name);
			}

			dgvProducts.Rows.Clear();

			dgvProducts.ColumnCount = 3;
			dgvProducts.Columns[0].Name = "Nome produto";
			dgvProducts.Columns[1].Name = "Valor produto";
			dgvProducts.Columns[2].Name = "Marca produto";

			for (int i = 0; i < dgvProducts.ColumnCount; ++i)
				dgvProducts.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			for (int i = 0; i < FormMain.Products.Count; ++i)
				dgvProducts.Rows.Add(new object[] {FormMain.Products[i].Name, FormMain.Products[i].Price, FormMain.Products[i].Brand.Name});

		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			Brand productBrand = new("");

			if (txtProductName.Text.Trim() == "") return;
			if (cbxBrands.SelectedIndex < 0) return;

			string productName = txtProductName.Text.Trim();
			float productPrice = (float) numProductPrice.Value;

			for (int i = 0; i < FormMain.Brands.Count; ++i)
				if (FormMain.Brands[i].Name == (string) cbxBrands.Items[cbxBrands.SelectedIndex])
					productBrand = FormMain.Brands[i];


			FormMain.Products.Add(new Product(productName, productPrice, productBrand) );

			txtProductName.Text = "";
			numProductPrice.Value = 0;
			cbxBrands.Text = "";

			UpdateDataGrid();
		}

		private void btnRemoveProduct_Click(object sender, EventArgs e)
		{
			if (dgvProducts.SelectedRows.Count < 0) return;

			FormMain.Products.RemoveAt(dgvProducts.CurrentCell.RowIndex);
			UpdateDataGrid();
		}

		private void btnUpdateProduct_Click(object sender, EventArgs e)
		{
			FormMain.Products[dgvProducts.CurrentCell.RowIndex] = new(txtProductName.Text, (float) numProductPrice.Value, new(cbxBrands.Text));
			UpdateDataGrid();
		}

		private void dgvProducts_Click(object sender, EventArgs e)
		{
			if (dgvProducts.SelectedRows.Count > 0)
			{
				btnRemoveProduct.Enabled = true;
				btnUpdateProduct.Enabled = true;

				txtProductName.Text = dgvProducts.Rows[dgvProducts.CurrentCell.RowIndex].Cells[0].Value.ToString();
				numProductPrice.Value = Convert.ToDecimal(dgvProducts.Rows[dgvProducts.CurrentCell.RowIndex].Cells[1].Value);
				cbxBrands.Text = dgvProducts.Rows[dgvProducts.CurrentCell.RowIndex].Cells[2].Value.ToString();
			} 
		}
	}
}
