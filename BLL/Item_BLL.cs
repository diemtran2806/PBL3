using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
namespace BLL
{
    public class Item_BLL
    {
        private static Item_BLL _Instance;
        public static Item_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Item_BLL();
                }
                return _Instance;
            }
            private set { } //chỉ nội bộ lớp này mới đc set dữ liệu vào
        }
        private Item_BLL() { }
        public DataTable getCustomer()
        {
            return Customer_DAL.Instance.GetRecords();
            //return accounts;
        }
    }
}
