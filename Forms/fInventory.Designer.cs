namespace iMart.Forms
{
    partial class fInventory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvInven = new System.Windows.Forms.DataGridView();
            this.btnSearchInven = new FontAwesome.Sharp.IconButton();
            this.txbSearchInven = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmProductPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDeleteInven = new FontAwesome.Sharp.IconButton();
            this.btnUpdateInven = new FontAwesome.Sharp.IconButton();
            this.btnReadInven = new FontAwesome.Sharp.IconButton();
            this.btnCreateInven = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInven)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmProductPrice)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvInven);
            this.panel1.Controls.Add(this.btnSearchInven);
            this.panel1.Controls.Add(this.txbSearchInven);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 629);
            this.panel1.TabIndex = 0;
            // 
            // dtgvInven
            // 
            this.dtgvInven.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvInven.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvInven.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvInven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInven.Location = new System.Drawing.Point(3, 90);
            this.dtgvInven.Name = "dtgvInven";
            this.dtgvInven.RowHeadersWidth = 51;
            this.dtgvInven.RowTemplate.Height = 24;
            this.dtgvInven.Size = new System.Drawing.Size(514, 536);
            this.dtgvInven.TabIndex = 3;
            // 
            // btnSearchInven
            // 
            this.btnSearchInven.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearchInven.IconColor = System.Drawing.Color.Black;
            this.btnSearchInven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchInven.IconSize = 36;
            this.btnSearchInven.Location = new System.Drawing.Point(310, 14);
            this.btnSearchInven.Name = "btnSearchInven";
            this.btnSearchInven.Size = new System.Drawing.Size(59, 42);
            this.btnSearchInven.TabIndex = 2;
            this.btnSearchInven.UseVisualStyleBackColor = true;
            // 
            // txbSearchInven
            // 
            this.txbSearchInven.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearchInven.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchInven.Location = new System.Drawing.Point(112, 20);
            this.txbSearchInven.Multiline = true;
            this.txbSearchInven.Name = "txbSearchInven";
            this.txbSearchInven.Size = new System.Drawing.Size(192, 36);
            this.txbSearchInven.TabIndex = 1;
            this.txbSearchInven.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbProductID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 63);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txbProductID
            // 
            this.txbProductID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbProductID.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductID.Location = new System.Drawing.Point(138, 14);
            this.txbProductID.Multiline = true;
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.ReadOnly = true;
            this.txbProductID.Size = new System.Drawing.Size(230, 36);
            this.txbProductID.TabIndex = 4;
            this.txbProductID.WordWrap = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Location = new System.Drawing.Point(535, 293);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(385, 348);
            this.panel6.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmProductPrice);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(385, 63);
            this.panel4.TabIndex = 6;
            // 
            // nmProductPrice
            // 
            this.nmProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmProductPrice.DecimalPlaces = 2;
            this.nmProductPrice.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmProductPrice.Location = new System.Drawing.Point(138, 14);
            this.nmProductPrice.Name = "nmProductPrice";
            this.nmProductPrice.Size = new System.Drawing.Size(230, 41);
            this.nmProductPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbSupplier);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(385, 63);
            this.panel5.TabIndex = 6;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSupplier.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(138, 14);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(230, 46);
            this.cbSupplier.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Supplier";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txbProductName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 63);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txbProductName
            // 
            this.txbProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbProductName.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductName.Location = new System.Drawing.Point(138, 14);
            this.txbProductName.Multiline = true;
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(230, 36);
            this.txbProductName.TabIndex = 4;
            this.txbProductName.WordWrap = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnDeleteInven);
            this.panel7.Controls.Add(this.btnUpdateInven);
            this.panel7.Controls.Add(this.btnReadInven);
            this.panel7.Controls.Add(this.btnCreateInven);
            this.panel7.Location = new System.Drawing.Point(535, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(385, 206);
            this.panel7.TabIndex = 8;
            // 
            // btnDeleteInven
            // 
            this.btnDeleteInven.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInven.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeleteInven.IconColor = System.Drawing.Color.Black;
            this.btnDeleteInven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteInven.Location = new System.Drawing.Point(223, 123);
            this.btnDeleteInven.Name = "btnDeleteInven";
            this.btnDeleteInven.Size = new System.Drawing.Size(123, 47);
            this.btnDeleteInven.TabIndex = 7;
            this.btnDeleteInven.Text = "Delete";
            this.btnDeleteInven.UseVisualStyleBackColor = true;
            this.btnDeleteInven.Click += new System.EventHandler(this.btnDeleteInven_Click);
            // 
            // btnUpdateInven
            // 
            this.btnUpdateInven.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInven.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdateInven.IconColor = System.Drawing.Color.Black;
            this.btnUpdateInven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateInven.Location = new System.Drawing.Point(40, 123);
            this.btnUpdateInven.Name = "btnUpdateInven";
            this.btnUpdateInven.Size = new System.Drawing.Size(123, 47);
            this.btnUpdateInven.TabIndex = 6;
            this.btnUpdateInven.Text = "Update";
            this.btnUpdateInven.UseVisualStyleBackColor = true;
            this.btnUpdateInven.Click += new System.EventHandler(this.btnUpdateInven_Click);
            // 
            // btnReadInven
            // 
            this.btnReadInven.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadInven.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReadInven.IconColor = System.Drawing.Color.Black;
            this.btnReadInven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReadInven.Location = new System.Drawing.Point(223, 40);
            this.btnReadInven.Name = "btnReadInven";
            this.btnReadInven.Size = new System.Drawing.Size(123, 47);
            this.btnReadInven.TabIndex = 5;
            this.btnReadInven.Text = "Read";
            this.btnReadInven.UseVisualStyleBackColor = true;
            this.btnReadInven.Click += new System.EventHandler(this.btnReadInven_Click);
            // 
            // btnCreateInven
            // 
            this.btnCreateInven.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInven.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCreateInven.IconColor = System.Drawing.Color.Black;
            this.btnCreateInven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateInven.Location = new System.Drawing.Point(40, 40);
            this.btnCreateInven.Name = "btnCreateInven";
            this.btnCreateInven.Size = new System.Drawing.Size(123, 47);
            this.btnCreateInven.TabIndex = 4;
            this.btnCreateInven.Text = "Create";
            this.btnCreateInven.UseVisualStyleBackColor = true;
            this.btnCreateInven.Click += new System.EventHandler(this.btnCreateInven_Click);
            // 
            // fInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "fInventory";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInven)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmProductPrice)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbSearchInven;
        private FontAwesome.Sharp.IconButton btnSearchInven;
        private System.Windows.Forms.DataGridView dtgvInven;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmProductPrice;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton btnCreateInven;
        private FontAwesome.Sharp.IconButton btnReadInven;
        private FontAwesome.Sharp.IconButton btnDeleteInven;
        private FontAwesome.Sharp.IconButton btnUpdateInven;
        private System.Windows.Forms.ComboBox cbSupplier;
    }
}