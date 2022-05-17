using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
        }
        public delegate void Mydel();
        public Mydel d { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text.Trim() == "")
                MessageBox.Show("Please fill in the required information!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Categories categories = new Categories
                {
                    Name_PG = txtGroupName.Text,
                };
                Categories_BLL.Instance.ExcuteDB(categories, "Add");
                //show

                MessageBox.Show("Added successfully");
                d();
                this.Close();
            }
        }
    }
}
