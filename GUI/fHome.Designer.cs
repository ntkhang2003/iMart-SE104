namespace iMart.Forms
{
    partial class fHome
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchItem = new FontAwesome.Sharp.IconButton();
            this.txbSearchItem = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flpItem = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmItemCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new FontAwesome.Sharp.IconButton();
            this.txbItemName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPay = new FontAwesome.Sharp.IconButton();
            this.btnAddOrder = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItemCount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchItem);
            this.panel2.Controls.Add(this.txbSearchItem);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 45);
            this.panel2.TabIndex = 1;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearchItem.IconColor = System.Drawing.Color.Black;
            this.btnSearchItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchItem.IconSize = 36;
            this.btnSearchItem.Location = new System.Drawing.Point(321, 3);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(59, 42);
            this.btnSearchItem.TabIndex = 1;
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // txbSearchItem
            // 
            this.txbSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearchItem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchItem.Location = new System.Drawing.Point(123, 6);
            this.txbSearchItem.Multiline = true;
            this.txbSearchItem.Name = "txbSearchItem";
            this.txbSearchItem.Size = new System.Drawing.Size(192, 36);
            this.txbSearchItem.TabIndex = 0;
            this.txbSearchItem.WordWrap = false;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Location = new System.Drawing.Point(492, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            this.panel4.TabIndex = 3;
            // 
            // flpItem
            // 
            this.flpItem.AutoScroll = true;
            this.flpItem.Location = new System.Drawing.Point(12, 63);
            this.flpItem.Name = "flpItem";
            this.flpItem.Size = new System.Drawing.Size(522, 578);
            this.flpItem.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmItemCount);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.txbItemName);
            this.panel1.Location = new System.Drawing.Point(540, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 45);
            this.panel1.TabIndex = 2;
            // 
            // nmItemCount
            // 
            this.nmItemCount.AllowDrop = true;
            this.nmItemCount.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmItemCount.Location = new System.Drawing.Point(237, 6);
            this.nmItemCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmItemCount.Name = "nmItemCount";
            this.nmItemCount.Size = new System.Drawing.Size(55, 45);
            this.nmItemCount.TabIndex = 2;
            this.nmItemCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddItem
            // 
            this.btnAddItem.Enabled = false;
            this.btnAddItem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddItem.IconColor = System.Drawing.Color.Black;
            this.btnAddItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddItem.IconSize = 36;
            this.btnAddItem.Location = new System.Drawing.Point(298, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(59, 42);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txbItemName
            // 
            this.txbItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbItemName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbItemName.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbItemName.Location = new System.Drawing.Point(20, 8);
            this.txbItemName.Multiline = true;
            this.txbItemName.Name = "txbItemName";
            this.txbItemName.ReadOnly = true;
            this.txbItemName.Size = new System.Drawing.Size(211, 36);
            this.txbItemName.TabIndex = 0;
            this.txbItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbItemName.WordWrap = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.btnAddOrder);
            this.panel3.Location = new System.Drawing.Point(540, 588);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 53);
            this.panel3.TabIndex = 3;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnPay.Enabled = false;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPay.IconColor = System.Drawing.Color.Black;
            this.btnPay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPay.Location = new System.Drawing.Point(206, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(123, 47);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Make payment";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddOrder.IconColor = System.Drawing.Color.Black;
            this.btnAddOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddOrder.Location = new System.Drawing.Point(69, 3);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(123, 47);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Add order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lsvBill);
            this.panel6.Location = new System.Drawing.Point(540, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(380, 460);
            this.panel6.TabIndex = 4;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.UnitPrice,
            this.Quantity,
            this.Amount});
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(380, 460);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.Visible = false;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 139;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "UnitPrice";
            this.UnitPrice.Width = 72;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 61;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 102;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbTotal);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(540, 529);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 53);
            this.panel5.TabIndex = 4;
            // 
            // txbTotal
            // 
            this.txbTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbTotal.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(173, 5);
            this.txbTotal.Multiline = true;
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(151, 45);
            this.txbTotal.TabIndex = 3;
            this.txbTotal.Text = "$0";
            this.txbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbTotal.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flpItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "fHome";
            this.Text = "fHome";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItemCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbSearchItem;
        private FontAwesome.Sharp.IconButton btnSearchItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flpItem;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAddItem;
        private System.Windows.Forms.TextBox txbItemName;
        private System.Windows.Forms.NumericUpDown nmItemCount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotal;
        private FontAwesome.Sharp.IconButton btnAddOrder;
    }
}