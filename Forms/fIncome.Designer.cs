namespace iMart.Forms
{
    partial class fIncome
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
            this.dtvgBillManifest = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManifest = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.txbTotalTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvgBillManifest)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtvgBillManifest);
            this.panel1.Location = new System.Drawing.Point(12, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 386);
            this.panel1.TabIndex = 0;
            // 
            // dtvgBillManifest
            // 
            this.dtvgBillManifest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvgBillManifest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtvgBillManifest.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvgBillManifest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvgBillManifest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvgBillManifest.Location = new System.Drawing.Point(57, 20);
            this.dtvgBillManifest.Name = "dtvgBillManifest";
            this.dtvgBillManifest.ReadOnly = true;
            this.dtvgBillManifest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtvgBillManifest.RowTemplate.Height = 24;
            this.dtvgBillManifest.Size = new System.Drawing.Size(782, 346);
            this.dtvgBillManifest.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnManifest);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 147);
            this.panel2.TabIndex = 1;
            // 
            // btnManifest
            // 
            this.btnManifest.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManifest.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnManifest.IconColor = System.Drawing.Color.Black;
            this.btnManifest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManifest.Location = new System.Drawing.Point(392, 67);
            this.btnManifest.Name = "btnManifest";
            this.btnManifest.Size = new System.Drawing.Size(123, 47);
            this.btnManifest.TabIndex = 2;
            this.btnManifest.Text = "Manifest";
            this.btnManifest.UseVisualStyleBackColor = true;
            this.btnManifest.Click += new System.EventHandler(this.btnManifest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkToDate.Location = new System.Drawing.Point(567, 14);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(147, 30);
            this.dtpkToDate.TabIndex = 3;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFromDate.Location = new System.Drawing.Point(302, 14);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(159, 30);
            this.dtpkFromDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbNumber);
            this.panel3.Controls.Add(this.txbTotalTotal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 557);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(905, 84);
            this.panel3.TabIndex = 2;
            // 
            // txbNumber
            // 
            this.txbNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbNumber.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumber.Location = new System.Drawing.Point(246, 25);
            this.txbNumber.Multiline = true;
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.ReadOnly = true;
            this.txbNumber.Size = new System.Drawing.Size(147, 45);
            this.txbNumber.TabIndex = 5;
            this.txbNumber.Text = "0";
            this.txbNumber.WordWrap = false;
            // 
            // txbTotalTotal
            // 
            this.txbTotalTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTotalTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbTotalTotal.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalTotal.Location = new System.Drawing.Point(660, 25);
            this.txbTotalTotal.Multiline = true;
            this.txbTotalTotal.Name = "txbTotalTotal";
            this.txbTotalTotal.ReadOnly = true;
            this.txbTotalTotal.Size = new System.Drawing.Size(151, 45);
            this.txbTotalTotal.TabIndex = 4;
            this.txbTotalTotal.Text = "$0";
            this.txbTotalTotal.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 42);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of bill";
            // 
            // fIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fIncome";
            this.Text = "fIncome";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvgBillManifest)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnManifest;
        private System.Windows.Forms.DataGridView dtvgBillManifest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTotalTotal;
        private System.Windows.Forms.TextBox txbNumber;
    }
}