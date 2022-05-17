using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddCategories : Form
    {
        public AddCategories()
        {
            InitializeComponent();
        }

        public delegate void Mydel();
        public Mydel d { get; set; }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (txtName_G_Add.Text.Trim() == "")
                MessageBox.Show("Please fill in the required information!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Customer customer = new Customer
                {
                    Name_Customer = tbName.Text,
                    Gender_Customer = rbtnFemale.Checked ? "Nữ" : "Nam",
                    Address_Customer = tbAddress.Text,
                    PhoneNumber_Customer = tbPhoneNumber.Text,
                    AccountNumber = tbAccountNumber.Text
                };
                Customer_BLL.Instance.ExcuteDB(customer, "Add");
                //show

                MessageBox.Show("Added successfully");
                d();
                this.Close();
            }
        }
    }
}
