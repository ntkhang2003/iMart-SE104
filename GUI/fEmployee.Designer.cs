namespace iMart.Forms
{
    partial class fEmployee
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnResetPassword = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpItem = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new FontAwesome.Sharp.IconButton();
            this.btnEditAccount = new FontAwesome.Sharp.IconButton();
            this.btnDeleteAccount = new FontAwesome.Sharp.IconButton();
            this.btnAddAccount = new FontAwesome.Sharp.IconButton();
            this.txbSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new FontAwesome.Sharp.IconButton();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnResetPassword);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(534, 72);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(386, 532);
            this.panel6.TabIndex = 1;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnResetPassword.IconColor = System.Drawing.Color.Black;
            this.btnResetPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetPassword.Location = new System.Drawing.Point(154, 200);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(226, 47);
            this.btnResetPassword.TabIndex = 0;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.numericUpDown2);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(3, 139);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(383, 62);
            this.panel7.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(161, 9);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(216, 41);
            this.numericUpDown2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account type";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDisplayName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 62);
            this.panel3.TabIndex = 2;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayName.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(161, 8);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(216, 38);
            this.txtDisplayName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display name";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtUsername);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 62);
            this.panel5.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(161, 9);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 38);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // flpItem
            // 
            this.flpItem.AutoScroll = true;
            this.flpItem.Controls.Add(this.dtgvAccount);
            this.flpItem.Location = new System.Drawing.Point(12, 72);
            this.flpItem.Name = "flpItem";
            this.flpItem.Size = new System.Drawing.Size(519, 532);
            this.flpItem.TabIndex = 11;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(513, 515);
            this.dtgvAccount.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchEmployee);
            this.panel1.Controls.Add(this.txbSearchEmployee);
            this.panel1.Location = new System.Drawing.Point(534, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Location = new System.Drawing.Point(492, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShowAccount);
            this.panel2.Controls.Add(this.btnEditAccount);
            this.panel2.Controls.Add(this.btnDeleteAccount);
            this.panel2.Controls.Add(this.btnAddAccount);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 54);
            this.panel2.TabIndex = 5;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnShowAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAccount.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAccount.ForeColor = System.Drawing.Color.White;
            this.btnShowAccount.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnShowAccount.IconColor = System.Drawing.Color.Black;
            this.btnShowAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowAccount.Location = new System.Drawing.Point(396, 5);
            this.btnShowAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(123, 47);
            this.btnShowAccount.TabIndex = 0;
            this.btnShowAccount.Text = "View";
            this.btnShowAccount.UseVisualStyleBackColor = false;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccount.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.ForeColor = System.Drawing.Color.White;
            this.btnEditAccount.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEditAccount.IconColor = System.Drawing.Color.Black;
            this.btnEditAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditAccount.Location = new System.Drawing.Point(264, 5);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(123, 47);
            this.btnEditAccount.TabIndex = 14;
            this.btnEditAccount.Text = "Edit";
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeleteAccount.IconColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteAccount.Location = new System.Drawing.Point(132, 5);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(123, 47);
            this.btnDeleteAccount.TabIndex = 13;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddAccount.IconColor = System.Drawing.Color.Black;
            this.btnAddAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAccount.Location = new System.Drawing.Point(0, 5);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(123, 47);
            this.btnAddAccount.TabIndex = 12;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txbSearchEmployee
            // 
            this.txbSearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearchEmployee.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchEmployee.Location = new System.Drawing.Point(73, 7);
            this.txbSearchEmployee.Multiline = true;
            this.txbSearchEmployee.Name = "txbSearchEmployee";
            this.txbSearchEmployee.Size = new System.Drawing.Size(192, 36);
            this.txbSearchEmployee.TabIndex = 2;
            this.txbSearchEmployee.WordWrap = false;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearchEmployee.IconColor = System.Drawing.Color.Black;
            this.btnSearchEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchEmployee.IconSize = 36;
            this.btnSearchEmployee.Location = new System.Drawing.Point(271, 5);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(59, 42);
            this.btnSearchEmployee.TabIndex = 3;
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 616);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flpItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "fEmployee";
            this.Text = "fEmployee";
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flpItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flpItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private FontAwesome.Sharp.IconButton btnShowAccount;
        private FontAwesome.Sharp.IconButton btnEditAccount;
        private FontAwesome.Sharp.IconButton btnDeleteAccount;
        private FontAwesome.Sharp.IconButton btnAddAccount;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnResetPassword;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox txbSearchEmployee;
        private FontAwesome.Sharp.IconButton btnSearchEmployee;
    }
}