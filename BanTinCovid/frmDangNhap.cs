using BanTinCovid.Models;
using BanTinCovid.Reponsitory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BanTinCovid
{
    public partial class frmDangNhap : Form
    {
        NhanVienRepository _repository = new NhanVienRepository();
        public static bool check;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private async void KiemTraDangNhap()
        {
            List<NhanVienViewModel> listNV = await _repository.getList();
            string user = txt_TaiKhoan.Text;
            string pass = txt_MatMa.Text;
            if (listNV.FindIndex(x => x.MaNhanVien == user) == listNV.FindIndex(x => x.MatKhau == pass))
             {
                    check = true;
             }
            else
             {
                    check = false;
             }
            if (check == true)
            {
                Program.MaNV = txt_TaiKhoan.Text;
                MessageBox.Show("Đăng nhập thành công!", "", MessageBoxButtons.OK);
                Program.frmChinh.button_NhanVien.Enabled = Program.frmChinh.button_TheLoai.Enabled = Program.frmChinh.button_tinhHinhCacTinh.Enabled = Program.frmChinh.button_TinhHinhChung.Enabled = Program.frmChinh.button_TinTuc.Enabled = true;
                Program.frmChinh.button_DangNhap.Enabled = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại vui lòng kiểm tra lại thông tin!", "", MessageBoxButtons.OK);
            }
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap();
            
        }
    }
}
