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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmItemCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new FontAwesome.Sharp.IconButton();
            this.txbItemName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItemCount)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchItem);
            this.panel2.Controls.Add(this.txbSearchItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 39);
            this.panel2.TabIndex = 1;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchItem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearchItem.IconColor = System.Drawing.Color.Black;
            this.btnSearchItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchItem.IconSize = 36;
            this.btnSearchItem.Location = new System.Drawing.Point(313, 0);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(71, 39);
            this.btnSearchItem.TabIndex = 1;
            this.btnSearchItem.UseVisualStyleBackColor = true;
            // 
            // txbSearchItem
            // 
            this.txbSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearchItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.txbSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchItem.Location = new System.Drawing.Point(0, 0);
            this.txbSearchItem.Multiline = true;
            this.txbSearchItem.Name = "txbSearchItem";
            this.txbSearchItem.Size = new System.Drawing.Size(216, 39);
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
            this.flpItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpItem.Location = new System.Drawing.Point(0, 0);
            this.flpItem.Name = "flpItem";
            this.flpItem.Size = new System.Drawing.Size(497, 552);
            this.flpItem.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(503, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(384, 552);
            this.panel5.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmItemCount);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.txbItemName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 39);
            this.panel1.TabIndex = 2;
            // 
            // nmItemCount
            // 
            this.nmItemCount.Location = new System.Drawing.Point(198, 9);
            this.nmItemCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmItemCount.Name = "nmItemCount";
            this.nmItemCount.Size = new System.Drawing.Size(53, 22);
            this.nmItemCount.TabIndex = 2;
            this.nmItemCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddItem
            // 
            this.btnAddItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddItem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddItem.IconColor = System.Drawing.Color.Black;
            this.btnAddItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddItem.IconSize = 36;
            this.btnAddItem.Location = new System.Drawing.Point(345, 0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(39, 39);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // txbItemName
            // 
            this.txbItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbItemName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbItemName.Location = new System.Drawing.Point(0, 0);
            this.txbItemName.Multiline = true;
            this.txbItemName.Name = "txbItemName";
            this.txbItemName.ReadOnly = true;
            this.txbItemName.Size = new System.Drawing.Size(192, 39);
            this.txbItemName.TabIndex = 0;
            this.txbItemName.WordWrap = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 55);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lsvBill);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(384, 419);
            this.panel6.TabIndex = 4;
            // 
            // lsvBill
            // 
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(384, 419);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 552);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flpItem);
            this.Controls.Add(this.panel4);
            this.Name = "fHome";
            this.Text = "fHome";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItemCount)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbSearchItem;
        private FontAwesome.Sharp.IconButton btnSearchItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flpItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAddItem;
        private System.Windows.Forms.TextBox txbItemName;
        private System.Windows.Forms.NumericUpDown nmItemCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView lsvBill;
    }
}