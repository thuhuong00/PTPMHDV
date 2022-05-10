using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanTinCovid.Models
{
    public class NhanVienViewModel
    {
        public string MaNhanVien { get; set; }
        public string cccd { get; set; }
        public string HoTen { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public string email { get; set; }
        public Nullable<int> TrangThaiXoa { get; set; }
        public string MatKhau { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
    }
}