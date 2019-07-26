using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_2018.Model.Schema
{
    class BienLaiExcel
    {
        public string SBD { get; set; }
        public string Name { get; set; }
        public string MaNganh { get; set; }
        public string TenNganh { get; set; }
        public string CMND { get; set; }
        public string Lop { get; set; }
        public string TenChuongTrinh { get; set; }
        public decimal TongTienDaThu { get; set; }
        public decimal TienHocPhi { get; set; }
        public decimal TienBHYT { get; set; }
        public decimal TienBHTT { get; set; }
        public decimal TienGDQP { get; set; }
        public decimal TienAVDV { get; set; }
        public decimal TienKhamSK { get; set; }
        public bool DaNopTien { get; set; }
    }
}
