namespace GoodsDeliveryNote
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
			this.OrderListView = new System.Windows.Forms.DataGridView();
			this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalOrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalOrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AgentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderDetailView = new System.Windows.Forms.DataGridView();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExportBtn = new System.Windows.Forms.Button();
			this.PaidBtn = new System.Windows.Forms.Button();
			this.UnpaidBtn = new System.Windows.Forms.Button();
			this.TransferBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.IdLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.OrderListView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderDetailView)).BeginInit();
			this.SuspendLayout();
			// 
			// OrderListView
			// 
			this.OrderListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrderListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.TotalOrderPrice,
            this.TotalOrderQuantity,
            this.OrderedDate,
            this.Status,
            this.AgentName});
			this.OrderListView.Location = new System.Drawing.Point(12, 12);
			this.OrderListView.Name = "OrderListView";
			this.OrderListView.RowHeadersWidth = 51;
			this.OrderListView.RowTemplate.Height = 24;
			this.OrderListView.Size = new System.Drawing.Size(821, 280);
			this.OrderListView.TabIndex = 0;
			this.OrderListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.OrderListView.SelectionChanged += new System.EventHandler(this.OrderListView_SelectionChanged);
			// 
			// OrderID
			// 
			this.OrderID.HeaderText = "Order ID";
			this.OrderID.MinimumWidth = 6;
			this.OrderID.Name = "OrderID";
			this.OrderID.ReadOnly = true;
			this.OrderID.Width = 125;
			// 
			// TotalOrderPrice
			// 
			this.TotalOrderPrice.HeaderText = "Total Order Price";
			this.TotalOrderPrice.MinimumWidth = 6;
			this.TotalOrderPrice.Name = "TotalOrderPrice";
			this.TotalOrderPrice.ReadOnly = true;
			this.TotalOrderPrice.Width = 125;
			// 
			// TotalOrderQuantity
			// 
			this.TotalOrderQuantity.HeaderText = "Total Order Quantity";
			this.TotalOrderQuantity.MinimumWidth = 6;
			this.TotalOrderQuantity.Name = "TotalOrderQuantity";
			this.TotalOrderQuantity.ReadOnly = true;
			this.TotalOrderQuantity.Width = 125;
			// 
			// OrderedDate
			// 
			this.OrderedDate.HeaderText = "Ordered Date";
			this.OrderedDate.MinimumWidth = 6;
			this.OrderedDate.Name = "OrderedDate";
			this.OrderedDate.ReadOnly = true;
			this.OrderedDate.Width = 125;
			// 
			// Status
			// 
			this.Status.HeaderText = "Status";
			this.Status.MinimumWidth = 6;
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Width = 125;
			// 
			// AgentName
			// 
			this.AgentName.HeaderText = "Agent Name";
			this.AgentName.MinimumWidth = 6;
			this.AgentName.Name = "AgentName";
			this.AgentName.ReadOnly = true;
			this.AgentName.Width = 125;
			// 
			// OrderDetailView
			// 
			this.OrderDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrderDetailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductQuantity,
            this.ProductPrice});
			this.OrderDetailView.Location = new System.Drawing.Point(12, 394);
			this.OrderDetailView.Name = "OrderDetailView";
			this.OrderDetailView.RowHeadersWidth = 51;
			this.OrderDetailView.RowTemplate.Height = 24;
			this.OrderDetailView.Size = new System.Drawing.Size(821, 250);
			this.OrderDetailView.TabIndex = 1;
			this.OrderDetailView.SelectionChanged += new System.EventHandler(this.OrderDetailView_SelectionChanged);
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "Name";
			this.ProductName.MinimumWidth = 6;
			this.ProductName.Name = "ProductName";
			this.ProductName.ReadOnly = true;
			this.ProductName.Width = 125;
			// 
			// ProductQuantity
			// 
			this.ProductQuantity.HeaderText = "Quantity";
			this.ProductQuantity.MinimumWidth = 6;
			this.ProductQuantity.Name = "ProductQuantity";
			this.ProductQuantity.ReadOnly = true;
			this.ProductQuantity.Width = 125;
			// 
			// ProductPrice
			// 
			this.ProductPrice.HeaderText = "Price";
			this.ProductPrice.MinimumWidth = 6;
			this.ProductPrice.Name = "ProductPrice";
			this.ProductPrice.ReadOnly = true;
			this.ProductPrice.Width = 125;
			// 
			// ExportBtn
			// 
			this.ExportBtn.Location = new System.Drawing.Point(860, 394);
			this.ExportBtn.Name = "ExportBtn";
			this.ExportBtn.Size = new System.Drawing.Size(96, 43);
			this.ExportBtn.TabIndex = 2;
			this.ExportBtn.Text = "Export";
			this.ExportBtn.UseVisualStyleBackColor = true;
			this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
			// 
			// PaidBtn
			// 
			this.PaidBtn.Location = new System.Drawing.Point(860, 68);
			this.PaidBtn.Name = "PaidBtn";
			this.PaidBtn.Size = new System.Drawing.Size(96, 43);
			this.PaidBtn.TabIndex = 3;
			this.PaidBtn.Text = "Paid";
			this.PaidBtn.UseVisualStyleBackColor = true;
			this.PaidBtn.Click += new System.EventHandler(this.PaidBtn_Click);
			// 
			// UnpaidBtn
			// 
			this.UnpaidBtn.Location = new System.Drawing.Point(860, 138);
			this.UnpaidBtn.Name = "UnpaidBtn";
			this.UnpaidBtn.Size = new System.Drawing.Size(96, 43);
			this.UnpaidBtn.TabIndex = 4;
			this.UnpaidBtn.Text = "Unpaid";
			this.UnpaidBtn.UseVisualStyleBackColor = true;
			this.UnpaidBtn.Click += new System.EventHandler(this.UnpaidBtn_Click);
			// 
			// TransferBtn
			// 
			this.TransferBtn.Location = new System.Drawing.Point(860, 204);
			this.TransferBtn.Name = "TransferBtn";
			this.TransferBtn.Size = new System.Drawing.Size(96, 43);
			this.TransferBtn.TabIndex = 5;
			this.TransferBtn.Text = "Transferring";
			this.TransferBtn.UseVisualStyleBackColor = true;
			this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(12, 350);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 31);
			this.label1.TabIndex = 6;
			this.label1.Text = "Order ID:";
			// 
			// IdLabel
			// 
			this.IdLabel.AutoSize = true;
			this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IdLabel.ForeColor = System.Drawing.Color.Tomato;
			this.IdLabel.Location = new System.Drawing.Point(153, 350);
			this.IdLabel.Name = "IdLabel";
			this.IdLabel.Size = new System.Drawing.Size(86, 31);
			this.IdLabel.TabIndex = 7;
			this.IdLabel.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1033, 717);
			this.Controls.Add(this.IdLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TransferBtn);
			this.Controls.Add(this.UnpaidBtn);
			this.Controls.Add(this.PaidBtn);
			this.Controls.Add(this.ExportBtn);
			this.Controls.Add(this.OrderDetailView);
			this.Controls.Add(this.OrderListView);
			this.Name = "Form1";
			this.Text = "List Orders";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.OrderListView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderDetailView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView OrderListView;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalOrderPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalOrderQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderedDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewTextBoxColumn AgentName;
		private System.Windows.Forms.DataGridView OrderDetailView;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
		private System.Windows.Forms.Button ExportBtn;
		private System.Windows.Forms.Button PaidBtn;
		private System.Windows.Forms.Button UnpaidBtn;
		private System.Windows.Forms.Button TransferBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label IdLabel;
	}
}

