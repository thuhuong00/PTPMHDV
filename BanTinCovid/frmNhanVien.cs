using BanTinCovid.Models;
using BanTinCovid.Reponsitory;
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
    public partial class frmNhanVien : Form
    {
        NhanVienRepository _repository = new NhanVienRepository();
        int numrow;
        public static string maNhanVienChon;
        public frmNhanVien()
        {
            InitializeComponent();
            LoadData();
            button_Xoa.Enabled = button_them.Enabled = false;
        }

        public async void LoadData()
        {
            var listNV = await _repository.getList();
            gridControl1.DataSource = listNV;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            var formThemNhanVien = new frmThemNhanVien();
            formThemNhanVien.Show();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numrow = e.RowHandle;
            object data = gridView1.GetRowCellValue(numrow, "MaNhanVien");
            maNhanVienChon = Convert.ToString(data);
            MessageBox.Show(maNhanVienChon);

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "", MessageBoxButtons.YesNo)*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                _repository.Delete(maNhanVienChon);
                MessageBox.Show("Đã xóa nhân viên vui lòng tải lại!");
            }
            
        }

        private void button_chinhSua_Click(object sender, EventArgs e)
        {
            var formChinhSuaNV = new frmChinhSuaNV();
            formChinhSuaNV.Show();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }
    }

}
