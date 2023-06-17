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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.pnBinding = new System.Windows.Forms.Panel();
            this.btnViewOld = new FontAwesome.Sharp.IconButton();
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
            this.btnRestoreInven = new FontAwesome.Sharp.IconButton();
            this.btnDeleteInven = new FontAwesome.Sharp.IconButton();
            this.btnUpdateInven = new FontAwesome.Sharp.IconButton();
            this.btnReadInven = new FontAwesome.Sharp.IconButton();
            this.btnCreateInven = new FontAwesome.Sharp.IconButton();
            this.txbSearchInven = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInven)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnBinding.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmProductPrice)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbSearchInven);
            this.panel1.Controls.Add(this.dtgvInven);
            this.panel1.Controls.Add(this.btnSearchInven);
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
            this.btnSearchInven.Click += new System.EventHandler(this.btnSearchInven_Click);
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
            // pnBinding
            // 
            this.pnBinding.Controls.Add(this.btnViewOld);
            this.pnBinding.Controls.Add(this.panel4);
            this.pnBinding.Controls.Add(this.panel5);
            this.pnBinding.Controls.Add(this.panel3);
            this.pnBinding.Controls.Add(this.panel2);
            this.pnBinding.Location = new System.Drawing.Point(538, 293);
            this.pnBinding.Name = "pnBinding";
            this.pnBinding.Size = new System.Drawing.Size(385, 348);
            this.pnBinding.TabIndex = 7;
            // 
            // btnViewOld
            // 
            this.btnViewOld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnViewOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOld.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOld.ForeColor = System.Drawing.Color.White;
            this.btnViewOld.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnViewOld.IconColor = System.Drawing.Color.Black;
            this.btnViewOld.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewOld.Location = new System.Drawing.Point(72, 275);
            this.btnViewOld.Name = "btnViewOld";
            this.btnViewOld.Size = new System.Drawing.Size(250, 47);
            this.btnViewOld.TabIndex = 8;
            this.btnViewOld.Text = "View old products";
            this.btnViewOld.UseVisualStyleBackColor = false;
            this.btnViewOld.Click += new System.EventHandler(this.btnViewOld_Click);
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
            this.cbSupplier.Location = new System.Drawing.Point(138, 11);
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
            this.panel7.Controls.Add(this.btnRestoreInven);
            this.panel7.Controls.Add(this.btnDeleteInven);
            this.panel7.Controls.Add(this.btnUpdateInven);
            this.panel7.Controls.Add(this.btnReadInven);
            this.panel7.Controls.Add(this.btnCreateInven);
            this.panel7.Location = new System.Drawing.Point(535, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(385, 189);
            this.panel7.TabIndex = 8;
            // 
            // btnRestoreInven
            // 
            this.btnRestoreInven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnRestoreInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreInven.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreInven.ForeColor = System.Drawing.Color.White;
            this.btnRestoreInven.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRestoreInven.IconColor = System.Drawing.Color.Black;
            this.btnRestoreInven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestoreInven.Location = new System.Drawing.Point(40, 31);
            this.btnRestoreInven.Name = "btnRestoreInven";
            this.btnRestoreInven.Size = new System.Drawing.Size(123, 47);
            this.btnRestoreInven.TabIndex = 8;
            this.btnRestoreInven.Text = "Restore";
            this.btnRestoreInven.UseVisualStyleBackColor = false;
            this.btnRestoreInven.Click += new System.EventHandler(this.btnRestoreInven_Click);
            // 
            // btnDeleteInven
            // 
            this.btnDeleteInven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnDeleteInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInven.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInven.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInven.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeleteInven.IconColor = System.Drawing.Color.Black;
            this.btnDeleteInven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteInven.Location = new System.Drawing.Point(223, 114);
            this.btnDeleteInven.Name = "btnDeleteInven";
            this.btnDeleteInven.Size = new System.Drawing.Size(123, 47);
            this.btnDeleteInven.TabIndex = 7;
            this.btnDeleteInven.Text = "Delete";
            this.btnDeleteInven.UseVisualStyleBackColor = false;
            this.btnDeleteInven.Click += new System.EventHandler(this.btnDeleteInven_Click);
            // 
            // btnUpdateInven
            // 
            this.btnUpdateInven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnUpdateInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInven.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInven.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInven.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdateInven.IconColor = System.Drawing.Color.Black;
            this.btnUpdateInven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateInven.Location = new System.Drawing.Point(40, 114);
            this.btnUpdateInven.Name = "btnUpdateInven";
            this.btnUpdateInven.Size = new System.Drawing.Size(123, 47);
            this.btnUpdateInven.TabIndex = 6;
            this.btnUpdateInven.Text = "Update";
            this.btnUpdateInven.UseVisualStyleBackColor = false;
            this.btnUpdateInven.Click += new System.EventHandler(this.btnUpdateInven_Click);
            // 
            // btnReadInven
            // 
            this.btnReadInven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnReadInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadInven.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadInven.ForeColor = System.Drawing.Color.White;
            this.btnReadInven.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReadInven.IconColor = System.Drawing.Color.Black;
            this.btnReadInven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReadInven.Location = new System.Drawing.Point(223, 31);
            this.btnReadInven.Name = "btnReadInven";
            this.btnReadInven.Size = new System.Drawing.Size(123, 47);
            this.btnReadInven.TabIndex = 5;
            this.btnReadInven.Text = "Read";
            this.btnReadInven.UseVisualStyleBackColor = false;
            this.btnReadInven.Click += new System.EventHandler(this.btnReadInven_Click);
            // 
            // btnCreateInven
            // 
            this.btnCreateInven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnCreateInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateInven.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInven.ForeColor = System.Drawing.Color.White;
            this.btnCreateInven.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCreateInven.IconColor = System.Drawing.Color.Black;
            this.btnCreateInven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateInven.Location = new System.Drawing.Point(40, 31);
            this.btnCreateInven.Name = "btnCreateInven";
            this.btnCreateInven.Size = new System.Drawing.Size(123, 47);
            this.btnCreateInven.TabIndex = 4;
            this.btnCreateInven.Text = "Create";
            this.btnCreateInven.UseVisualStyleBackColor = false;
            this.btnCreateInven.Click += new System.EventHandler(this.btnCreateInven_Click);
            // 
            // txbSearchInven
            // 
            this.txbSearchInven.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearchInven.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchInven.Location = new System.Drawing.Point(112, 14);
            this.txbSearchInven.Multiline = true;
            this.txbSearchInven.Name = "txbSearchInven";
            this.txbSearchInven.Size = new System.Drawing.Size(192, 40);
            this.txbSearchInven.TabIndex = 4;
            this.txbSearchInven.WordWrap = false;
            // 
            // fInventory
            // 
            this.AcceptButton = this.btnSearchInven;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pnBinding);
            this.Controls.Add(this.panel1);
            this.Name = "fInventory";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInven)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnBinding.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnSearchInven;
        private System.Windows.Forms.DataGridView dtgvInven;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnBinding;
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
        private FontAwesome.Sharp.IconButton btnViewOld;
        private FontAwesome.Sharp.IconButton btnRestoreInven;
        private System.Windows.Forms.TextBox txbSearchInven;
    }
}