using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PBL_3
{
    public partial class Register : Form
    {
        List_user listUS = new List_user();
        string confirmPass;
        public Register()
        {
            InitializeComponent();
            listUS.getDataUser();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {        
            Infor_user us = new Infor_user();
            if (us != null)
            {
                us.Name = txtName.Text;
                us.Address = txtAddress.Text;
                us.PhoneNumber = txtPhoneNum.Text;
                us.Birthday = DTPickerBirthday.Value;
                us.US = txtUserName.Text;
                us.PW = txtPass.Text;
                confirmPass = txtConfirmPassword.Text;
            }
            if (!us.checkPass(confirmPass)) MessageBox.Show("Password and confirm password does not match");
            else
            {
                if (listUS.checkUserName(txtUserName.Text)) MessageBox.Show("Username already exists");
                else
                {
                    Sql_connect sQL_Connect = new Sql_connect();
                    SqlConnection cn = sQL_Connect.connect();
                    using (cn)
                    {
                        String query = "INSERT INTO dbo.Infor_user (username,password,name,birthday,adress,phoneNumber) VALUES (@username,@password,@name,@birthday,@adress,@phoneNumber)";

                        using (SqlCommand command = new SqlCommand(query, cn))
                        {                            
                            command.Parameters.AddWithValue("@username", txtName.Text);
                            command.Parameters.AddWithValue("@password", txtPass.Text);
                            command.Parameters.AddWithValue("@name", txtName.Text);
                            command.Parameters.AddWithValue("@birthday", DTPickerBirthday.Value);
                            command.Parameters.AddWithValue("@adress", txtAddress.Text);
                            command.Parameters.AddWithValue("@phoneNumber", txtPhoneNum.Text);

                            cn.Open();
                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                                MessageBox.Show("Error inserting data into Database!");
                        }
                    }
                    MessageBox.Show("Sign Up Success");
                    this.Close();
                }
            }

        }
    }
}
