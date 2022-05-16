using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Categories_DAL
    {
        private static Categories_DAL _Instance;
        public static Categories_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Categories_DAL();
                }
                return _Instance;
            }
            private set { } //chỉ nội bộ lớp này mới đc set dữ liệu vào
        }
        private Categories_DAL() { }
        DataTable products = new DataTable();
        DataRow product;
        public DataTable GetRecords()
        {
            string query = "select ID_PG,Name_PG from ProductGroups";
            products = DataProvider.Instance.GetRecords(query);
            return products;
        }
    }
}
