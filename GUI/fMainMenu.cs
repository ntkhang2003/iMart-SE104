﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using iMart.DAO;
using iMart.DTO;
using iMart.Forms;

namespace iMart
{
    public partial class fMainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.accountType); }
        }

        public fMainMenu(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            lbWelcome.Text += " " + loginAccount.DisplayName;
            LoginAccount = loginAccount;
        }

        //Method

        void ChangeAccount(int type)
        {
            btnEmployee.Visible = type == 1;
            btnInventory.Visible = type == 1;
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = Color.FromArgb(0, 153, 76);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(0, 153, 76);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Color.FromArgb(0, 153, 76);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.FromArgb(255, 255, 255);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(255, 255, 255);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fHome(LoginAccount));
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fInventory());
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fIncome());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            fEmployee f = new fEmployee();
            f.loginAccount = LoginAccount;
            OpenChildForm(f);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            fAccount f = new fAccount(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;

            OpenChildForm(f);
        }

        void f_UpdateAccount(object sender, AccountEvent e)
        {
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to log out?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
