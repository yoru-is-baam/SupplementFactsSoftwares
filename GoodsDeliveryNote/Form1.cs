using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsDeliveryNote
{
	public partial class Form1 : Form
	{
		DevConn db = new DevConn();

		public Form1()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			PaidBtn.Enabled = false;
			UnpaidBtn.Enabled = false;
			TransferBtn.Enabled = false;
			ExportBtn.Enabled = false;

			// list orders
			var orders = db.OrderReceipts.ToList();
			var agents = db.Agents.ToList();

			for (int i = 0; i < orders.Count; i++)
			{
				var agentName = agents.FirstOrDefault(a => a.AgentID == orders[i].AgentID).AgentName;

				OrderListView.Rows.Add(orders[i].OrderID, String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", orders[i].TotalOrderPrice), orders[i].TotalOrderQuantity, orders[i].OrderedDate.ToShortDateString(), orders[i].Status, agentName);
			}
		}

		private void OrderListView_SelectionChanged(object sender, EventArgs e)
		{
			// clear order detail view
			OrderDetailView.Rows.Clear();

			var currentRow = OrderListView.CurrentRow;

			// If not select any row or cell
			if (currentRow.Cells[0].Value != null)
			{
				int orderId = (int)currentRow.Cells[0].Value;
				
				IdLabel.Text = orderId.ToString();

				var orderDetail = db.IncludeOrderProducts.Where(d => d.OrderID == orderId).ToList();

				for (int i = 0; i < orderDetail.Count; i++)
				{
					OrderDetailView.Rows.Add(GetProductName(orderDetail[i].ProductID), orderDetail[i].TotalProductQuantity, String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", orderDetail[i].TotalProductPrice)); ;
				}

				ExportBtn.Enabled = true;
				UnpaidBtn.Enabled = true;
				PaidBtn.Enabled = true;
				TransferBtn.Enabled = true;
			}
			else
			{
				IdLabel.Text = "";
				ExportBtn.Enabled = false;
				UnpaidBtn.Enabled = false;
				PaidBtn.Enabled = false;
				TransferBtn.Enabled = false;
			}
		}

		private string GetProductName(string productId)
		{
			var products = db.Products.ToList();

			var productName = products.FirstOrDefault(p => p.ProductID == productId).ProductName;

			return productName;
		}

		private void OrderDetailView_SelectionChanged(object sender, EventArgs e)
		{
		}

		private void PaidBtn_Click(object sender, EventArgs e)
		{
			UpdateStatus("Paid");
		}

		private void UpdateStatus(string status)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to make this order become " + status.ToLower() + "?", "Confirm action", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				var orderId = int.Parse(IdLabel.Text);
				var order = db.OrderReceipts.SingleOrDefault(o => o.OrderID == orderId);

				if (order != null)
				{
					order.Status = status;
					db.SaveChanges();

					OrderListView.Rows.Clear();
					Form1_Load(null, null);
				}
			}
		}

		private void UnpaidBtn_Click(object sender, EventArgs e)
		{
			UpdateStatus("Unpaid");
		}

		private void TransferBtn_Click(object sender, EventArgs e)
		{
			UpdateStatus("Transferring");
		}

		private void ExportExcel()
		{
			// creating Excel Application  
			Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

			// creating new WorkBook within Excel application  
			Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

			// creating new Excelsheet in workbook  
			Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

			// see the excel sheet behind the program  
			app.Visible = true;

			// get the reference of first sheet. By default its name is Sheet1.  
			// store its reference to worksheet  
			worksheet = workbook.Sheets["Sheet1"];
			worksheet = workbook.ActiveSheet;

			// changing the name of active sheet  
			worksheet.Name = "Exported from gridview";

			// storing header part in Excel
			int i, j = 0;

			for (i = 1; i < OrderDetailView.Columns.Count + 1; i++)
			{
				worksheet.Cells[1, i] = OrderDetailView.Columns[i - 1].HeaderText;
			}
			worksheet.Cells[1, i + 1] = "Order ID";

			// storing Each row and column value to excel sheet  
			for (i = 0; i < OrderDetailView.Rows.Count - 1; i++)
			{
				for (j = 0; j < OrderDetailView.Columns.Count; j++)
				{
					worksheet.Cells[i + 2, j + 1] = OrderDetailView.Rows[i].Cells[j].Value.ToString();
				}
			}
			worksheet.Cells[2, j + 2] = IdLabel.Text;

			string currDateTime = DateTime.Now.ToString("dd MM yyyy hh mm ss");
			string savepath = System.IO.Path.GetFullPath(currDateTime + ".xlsx");

			// save the application  
			workbook.SaveAs(savepath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			// Exit from the application  
			app.Quit();
		}

		private void ExportBtn_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to export this receipt?", "Confirm export", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				ExportExcel();
			}
		}
	}
}
