﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Supply_DAL
    {
        private static Supply_DAL _Instance;
        public static Supply_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Supply_DAL();
                }
                return _Instance;
            }
            private set { } //chỉ nội bộ lớp này mới đc set dữ liệu vào
        }
        private Supply_DAL() { }
        DataTable supply = new DataTable();
        public DataTable GetRecords()
        {
            string query = "select ID_Supply,Name_Supply,Address_Supply,PhoneNumber_Supply,BankAccount from Supply";
            supply = DataProvider.Instance.GetRecords(query);
            return supply;
        }
        public void addSupply(Supply supply)
        {
            string query = "insert into Supply(Name_Supply,Address_Supply,PhoneNumber_Supply,BankAccount) " + "values (N'" 
                + supply.Name_Supply + "',N'" + supply.Address_Supply + "','" + supply.PhoneNumber_Supply + "','" + supply.BankAccount + "')";
            DataProvider.Instance.ExcuteDB(query);
        }
        public void updateSupply(Supply supply)
        {
            string query = "update Supply set Name_Supply = N'" + supply.Name_Supply + "', Address_Supply = N'" + supply.Address_Supply 
                + "', PhoneNumber_Supply = '" + supply.PhoneNumber_Supply + "', BankAccount = '" + supply.BankAccount 
                + "' where ID_Supply = '" + supply.ID_Supply + "'";
            DataProvider.Instance.ExcuteDB(query);
        }
        public void deleteSupply(Supply supply, string id_supply)
        {
            string query = "delete from Supply where ID_Supply = '" + id_supply + "'";
            DataProvider.Instance.ExcuteDB(query);
        }
    }
}
