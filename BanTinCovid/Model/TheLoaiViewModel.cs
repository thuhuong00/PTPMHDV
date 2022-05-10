using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanTinCovid.Models
{
    public class TheLoaiViewModel
    {
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public string MoTa { get; set; }
    }
}