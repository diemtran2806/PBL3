using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class Categories_BLL
    {
        private static Categories_BLL _Instance;
        public static Categories_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Categories_BLL();
                }
                return _Instance;
            }
            private set { } //chỉ nội bộ lớp này mới đc set dữ liệu vào
        }
        private Categories_BLL() { }
        public DataTable getGroups()
        {
            return Categories_DAL.Instance.GetRecords();
        }
    }
}
