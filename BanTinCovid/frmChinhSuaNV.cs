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
    public partial class frmChinhSuaNV : DevExpress.XtraEditors.XtraForm
    {
        NhanVienRepository _repository = new NhanVienRepository();
        public frmChinhSuaNV()
        {
            InitializeComponent();
            LoadData();
        }
        public async void LoadData()
        {
            dataLayoutControl_chinhSuaNV.DataSource = await _repository.GetNV(frmNhanVien.maNhanVienChon);
        }
        private void button_ChinhSua_Click(object sender, EventArgs e)
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
            _repository.Update(nhanVien);
            this.Close();
        }
    }
}