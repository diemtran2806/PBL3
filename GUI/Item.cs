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
    public partial class Item : UserControl
    {

        private static Item _Instance;
        public static Item Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Item();
                }
                return _Instance;
            }
            private set { } //chỉ nội bộ lớp này mới đc set dữ liệu vào
        }

        public Item()
        {
            InitializeComponent();
        }


        private void Item_Load(object sender, EventArgs e)
        {

        }

        private int _id;
        private Image _img;

        private string _title;

        private string _unit;

        private string _price;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbName_Item.Text=value; }

        }
        [Category("Custom Props")]
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; lbUnit_Item.Text = value; }
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; lbPrice_Item.Text = value; }
        }

        public Image Img
        {
            get { return _img; }
            set { _img = value; pb_Item.Image = value; }
        }

        private void lbPrice_Item_Click(object sender, EventArgs e)
        {

        }

        private void lbUnit_Item_Click(object sender, EventArgs e)
        {

        }
    }
}
