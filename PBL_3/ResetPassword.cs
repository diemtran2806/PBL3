﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_3
{
    public partial class ResetPassword : Form
    {
        private Random rnd = new Random();
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(tbName.Text.Trim() == "" || tbEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in the required information");
                return;
            }
            //if (!listUS.checkUserName(txtUserName.Text)) MessageBox.Show("Username does not exist");
            //else
            //{
                int rd = rnd.Next(100000, 999999);
                if (sendMail.checkMail(tbEmail.Text) != "OK") MessageBox.Show(sendMail.checkMail(tbEmail.Text) + "\nPlease re-enter your email");
                else MessageBox.Show(sendMail.Send(tbEmail.Text, "Verification code", "Code: " + rd.ToString()));
            //}
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!btnSend.Checked)
            {
                MessageBox.Show("Please fill in the required information");
                return ;
            }
            if(tbCode.Text.Trim() == "") {
                MessageBox.Show("Please enter the verification code");
                return;
            }
            if (tbCode.Text != rnd.ToString())
            {
                MessageBox.Show("Confirmation code is incorrect");
            }
            else
            {
                NewPassword np = new NewPassword();
                this.Hide();
                np.ShowDialog();
                this.Close();
            }
        }
    }
}
