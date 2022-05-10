using BanTinCovid.view;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BanTinCovid
{
    static class Program
    {
        public static frmMain frmChinh;
        public static frmDangNhap formDangNhap;
        public static frmNhanVien formNhanVien;
        public static frmTinTuc formTinTuc;
        public static frmTheLoai formTheLoai;
        public static frmTinhHinhChung formTinhHinhChung;
        public static frmTrangChu formTrangChu;
        public static frmTL2 formTL2;
        public static frmTL3 formTL3;
        public static frmTL4 formTL4;
        public static frmHienTinTuc formHienTinTuc;
        public static string MaNV = "";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
