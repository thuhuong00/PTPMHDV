using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BanTinCovid.Models
{
    public class TinTucViewModel
    {
        public int MaTinTuc { get; set; }
        public string TenTinTuc { get; set; }
        public string MaTheLoai { get; set; }
        public string NoiDung { get; set; }
        public string NoiDungNgan { get; set; }
        public string TacGia { get; set; }
        public string MaNhanVien { get; set; }
        public System.DateTime Ngay { get; set; }

        public string hinhAnh { get; set; }

        public static explicit operator TinTucViewModel(Task<List<TinTucViewModel>> v)
        {
            throw new NotImplementedException();
        }
    }
}