namespace GoodsStatistics
{
	partial class Form1
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
			this.ProductListView = new System.Windows.Forms.DataGridView();
			this.BestSellingProductListView = new System.Windows.Forms.DataGridView();
			this.RevenueListView = new System.Windows.Forms.DataGridView();
			this.InBtn = new System.Windows.Forms.Button();
			this.OutBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.ProductListView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BestSellingProductListView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RevenueListView)).BeginInit();
			this.SuspendLayout();
			// 
			// ProductListView
			// 
			this.ProductListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProductListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.TotalProductPrice,
            this.TotalProductQuantity});
			this.ProductListView.Location = new System.Drawing.Point(370, 170);
			this.ProductListView.Name = "ProductListView";
			this.ProductListView.RowHeadersWidth = 51;
			this.ProductListView.RowTemplate.Height = 24;
			this.ProductListView.Size = new System.Drawing.Size(837, 178);
			this.ProductListView.TabIndex = 0;
			// 
			// BestSellingProductListView
			// 
			this.BestSellingProductListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BestSellingProductListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.BestSellingProductListView.Location = new System.Drawing.Point(48, 474);
			this.BestSellingProductListView.Name = "BestSellingProductListView";
			this.BestSellingProductListView.RowHeadersWidth = 51;
			this.BestSellingProductListView.RowTemplate.Height = 24;
			this.BestSellingProductListView.Size = new System.Drawing.Size(786, 183);
			this.BestSellingProductListView.TabIndex = 1;
			// 
			// RevenueListView
			// 
			this.RevenueListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.RevenueListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
			this.RevenueListView.Location = new System.Drawing.Point(956, 474);
			this.RevenueListView.Name = "RevenueListView";
			this.RevenueListView.RowHeadersWidth = 51;
			this.RevenueListView.RowTemplate.Height = 24;
			this.RevenueListView.Size = new System.Drawing.Size(499, 183);
			this.RevenueListView.TabIndex = 2;
			// 
			// InBtn
			// 
			this.InBtn.Location = new System.Drawing.Point(1253, 209);
			this.InBtn.Name = "InBtn";
			this.InBtn.Size = new System.Drawing.Size(124, 35);
			this.InBtn.TabIndex = 3;
			this.InBtn.Text = "In";
			this.InBtn.UseVisualStyleBackColor = true;
			this.InBtn.Click += new System.EventHandler(this.InBtn_Click);
			// 
			// OutBtn
			// 
			this.OutBtn.Location = new System.Drawing.Point(1253, 276);
			this.OutBtn.Name = "OutBtn";
			this.OutBtn.Size = new System.Drawing.Size(124, 35);
			this.OutBtn.TabIndex = 4;
			this.OutBtn.Text = "Out";
			this.OutBtn.UseVisualStyleBackColor = true;
			this.OutBtn.Click += new System.EventHandler(this.OutBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Purple;
			this.label1.Location = new System.Drawing.Point(561, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(436, 46);
			this.label1.TabIndex = 5;
			this.label1.Text = "Goods Statistics Form";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.OrangeRed;
			this.label2.Location = new System.Drawing.Point(148, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 31);
			this.label2.TabIndex = 6;
			this.label2.Text = "Stock Report";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.ForestGreen;
			this.label3.Location = new System.Drawing.Point(284, 429);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(278, 31);
			this.label3.TabIndex = 7;
			this.label3.Text = "Best Selling Product";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label4.Location = new System.Drawing.Point(1142, 429);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 31);
			this.label4.TabIndex = 8;
			this.label4.Text = "Revenue";
			// 
			// ProductID
			// 
			this.ProductID.HeaderText = "Product ID";
			this.ProductID.MinimumWidth = 6;
			this.ProductID.Name = "ProductID";
			this.ProductID.ReadOnly = true;
			this.ProductID.Width = 125;
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "Product Name";
			this.ProductName.MinimumWidth = 6;
			this.ProductName.Name = "ProductName";
			this.ProductName.ReadOnly = true;
			this.ProductName.Width = 125;
			// 
			// TotalProductPrice
			// 
			this.TotalProductPrice.HeaderText = "Total Product Price";
			this.TotalProductPrice.MinimumWidth = 6;
			this.TotalProductPrice.Name = "TotalProductPrice";
			this.TotalProductPrice.ReadOnly = true;
			this.TotalProductPrice.Width = 125;
			// 
			// TotalProductQuantity
			// 
			this.TotalProductQuantity.HeaderText = "Total Product Quantity";
			this.TotalProductQuantity.MinimumWidth = 6;
			this.TotalProductQuantity.Name = "TotalProductQuantity";
			this.TotalProductQuantity.ReadOnly = true;
			this.TotalProductQuantity.Width = 125;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Product ID";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Product Name";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Total Product Quantity";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Total Product Price";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Month";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 125;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Revenue";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 125;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1503, 772);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OutBtn);
			this.Controls.Add(this.InBtn);
			this.Controls.Add(this.RevenueListView);
			this.Controls.Add(this.BestSellingProductListView);
			this.Controls.Add(this.ProductListView);
			this.Name = "Form1";
			this.Text = "Goods Statistics Form";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.ProductListView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BestSellingProductListView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RevenueListView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView ProductListView;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalProductPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalProductQuantity;
		private System.Windows.Forms.DataGridView BestSellingProductListView;
		private System.Windows.Forms.DataGridView RevenueListView;
		private System.Windows.Forms.Button InBtn;
		private System.Windows.Forms.Button OutBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
	}
}

