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
        public void ExcuteDB(Categories categories, string id_categories = null) //update, delete
        {
            if (categories.ID_PG == null)
            {
                Categories_DAL.Instance.updateCategories(categories);
                return;
            }
            if (categories.ID_PG != null && !id_categories.Equals("Add"))
            {
                Categories_DAL.Instance.deleteCategories(categories);
                return;
            }
            if (id_categories.Equals("Add"))
            {
                Categories_DAL.Instance.addCategories(categories);
                return;
            }
        }
    }
}
