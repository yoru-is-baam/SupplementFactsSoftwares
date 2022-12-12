using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsStatistics
{
	public partial class Form1 : Form
	{
		DevConn db = new DevConn();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var bestSellingProduct = db.fnBestSellingProduct().ToList();
			var products = db.Products.ToList();

			for (int i = 0; i < bestSellingProduct.Count; i++)
			{
				var productName = products.FirstOrDefault(p => p.ProductID == bestSellingProduct[i].ProductID).ProductName;

				BestSellingProductListView.Rows.Add(bestSellingProduct[i].ProductID, productName, bestSellingProduct[i].TotalProductQuantity, String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", bestSellingProduct[i].TotalProductPrice));
			}

			var revenueEachMonth = db.fnRevenueEachMonth().ToList();

			for (int i = 0; i < revenueEachMonth.Count; i++)
			{
				RevenueListView.Rows.Add(revenueEachMonth[i].OrderedMonth, String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", revenueEachMonth[i].Revenue));
			}
		}

		private void InBtn_Click(object sender, EventArgs e)
		{
			ProductListView.Rows.Clear();

			var inProducts = db.fnProductsIn().ToList();
			var products = db.Products.ToList();

			for (int i = 0; i < inProducts.Count; i++) 
			{
				var productName = products.FirstOrDefault(p => p.ProductID == inProducts[i].ProductID).ProductName;

				ProductListView.Rows.Add(inProducts[i].ProductID, productName, String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", inProducts[i].TotalProductPrice), inProducts[i].TotalProductQuantity);
			}
		}

		private void OutBtn_Click(object sender, EventArgs e)
		{
			ProductListView.Rows.Clear();

			var outProducts = db.fnProductsOut().ToList();
			var products = db.Products.ToList();

			for (int i = 0; i < outProducts.Count; i++)
			{
				var productName = products.FirstOrDefault(p => p.ProductID == outProducts[i].ProductID).ProductName;

				ProductListView.Rows.Add(outProducts[i].ProductID, productName, String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", outProducts[i].TotalProductPrice), outProducts[i].TotalProductQuantity);
			}
		}
	}
}
