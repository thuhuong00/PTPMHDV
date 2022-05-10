using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanTinCovid.Models
{
    public class TinhHinhChungViewModel
    {
       
        public System.DateTime Ngay { get; set; }
        public int CaNhiem { get; set; }
        public int ChuaKhoi { get; set; }
        public int TuVong { get; set; }
        public string MaNhanVien  { get; set; }
    }
}