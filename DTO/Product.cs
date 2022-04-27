using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DTO
{
    public class Product
    {
        public int ID_P { get; set; }
        public string ID_PG { get; set; }
        public string Name_P { get; set; }
        public string Unit_P { get; set; }
        public long Price_P { get; set; }
        public long VAT { get; set; }
        public Decimal VATInclusive_P { get; set; }
        public byte[] IMG_P { get; set; }
    }
}
