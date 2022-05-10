using BanTinCovid.Models;
using BanTinCovid.Reponsitory;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanTinCovid
{
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienRepository _repository = new NhanVienRepository();
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            var nhanVien = new NhanVienViewModel();
            nhanVien.MaNhanVien = MaNhanVienTextEdit.Text;
            nhanVien.cccd = cccdTextEdit.Text;
            nhanVien.HoTen = HoTenTextEdit.Text;
            nhanVien.SoDT = SoDTTextEdit.Text;
            nhanVien.DiaChi = DiaChiTextEdit.Text;
            nhanVien.email = emailTextEdit.Text;
            nhanVien.TrangThaiXoa = Convert.ToInt32(TrangThaiXoaTextEdit.Text);
            nhanVien.MatKhau = MatKhauTextEdit.Text;
            nhanVien.NgaySinh = NgaySinhDateEdit.DateTime;
            _repository.Add(nhanVien);
            this.Close();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}