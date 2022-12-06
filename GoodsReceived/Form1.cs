using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GoodsReceived
{
	public partial class GoodsReceivedForm : Form
	{
		public GoodsReceivedForm()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void GoodsReceivedForm_Load(object sender, EventArgs e)
		{
			AddReceiptBtn.Enabled = false;
			ResetAllBtn.Enabled = false;
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (Products.Rows.Count > 1)
			{
				AddReceiptBtn.Enabled = true;
				ResetAllBtn.Enabled = true;
			}
		}

		private void ProductNameInput_TextChanged(object sender, EventArgs e)
		{

		}

		private void ProductIdInput_TextChanged(object sender, EventArgs e)
		{

		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			CheckValidationProductInput();

			string productId = ProductIdInput.Text;
			string productName = ProductNameInput.Text;
			string productQuantity = ProductQuantityInput.Text;
			string productPrice = ProductPriceInput.Text;

			Products.Rows.Add(productId, productName, productPrice, productQuantity);

			ResetBtn_Click(null, null);
		}

		void CheckValidationProductInput()
		{
			if (ProductIdInput.Text == "")
			{
				MessageBox.Show("Please enter product id");
				ProductIdInput.Focus();
			}
			else if (ProductNameInput.Text == "")
			{
				MessageBox.Show("Please enter product name");
				ProductNameInput.Focus();
			}
			else if (ProductPriceInput.Text == "" || !IsNumber(ProductPriceInput.Text))
			{
				MessageBox.Show("Please enter right product price");
				ProductPriceInput.Focus();
			}
			else if (ProductQuantityInput.Text == "" || !IsNumber(ProductQuantityInput.Text))
			{
				MessageBox.Show("Please enter right product quantity");
				ProductQuantityInput.Focus();
			}
		}

		bool IsNumber(string text)
		{
			Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
			return regex.IsMatch(text);
		}

		private void ResetBtn_Click(object sender, EventArgs e)
		{
			ProductPriceInput.Text = "";
			ProductNameInput.Text = "";
			ProductIdInput.Text = "";
			ProductQuantityInput.Text = "";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void ResetAllBtn_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to reset all products ?", "Confirm reset", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				Products.DataSource = null;
			}
		}
	}
}
