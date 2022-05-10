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
    public partial class frmTinhHinhChung : Form
    {
        private const string V = "";
        int numrow;
        public static DateTime ngayChon;
        TinhHinhChungRepository tinhHinhChungRepository = new TinhHinhChungRepository();
        public frmTinhHinhChung()
        {
            InitializeComponent();
            MaNhanVienTextEdit.Text = Program.MaNV;
            loadData();
        }
        public async void loadData()
        {
            var listTHC = await tinhHinhChungRepository.getList();
            gridControl1.DataSource = listTHC;
        }
        public async void LoadHangChonChinhSua()
        {
            dataLayoutControl1.DataSource = await tinhHinhChungRepository.GetTHC(ngayChon);
        }
        public void xoaDuLieu()
        {
            NgayDateEdit.Text = V;
            CaNhiemTextEdit.Text = V;
            ChuaKhoiTextEdit.Text = V;
            TuVongTextEdit.Text = V;
            MaNhanVienTextEdit.Text = Program.MaNV;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var tinhHinhChung = new TinhHinhChungViewModel();
            tinhHinhChung.Ngay = NgayDateEdit.DateTime;
            tinhHinhChung.CaNhiem = (int)Convert.ToDecimal(CaNhiemTextEdit.Text);
            tinhHinhChung.ChuaKhoi = (int)Convert.ToDecimal(ChuaKhoiTextEdit.Text);
            tinhHinhChung.TuVong = (int)Convert.ToDecimal(TuVongTextEdit.Text);
            tinhHinhChung.MaNhanVien = Program.MaNV;
            tinhHinhChungRepository.Add(tinhHinhChung);
            xoaDuLieu();
            MessageBox.Show("Thành công, vui lòng tải lại!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tinhHinhChung = new TinhHinhChungViewModel();
            tinhHinhChung.Ngay = NgayDateEdit.DateTime;
            //tinhHinhChung.CaNhiem = (int)Convert.ToDecimal(CaNhiemTextEdit.Text);
            tinhHinhChung.CaNhiem = (int)Convert.ToDecimal(CaNhiemTextEdit.Text);
            tinhHinhChung.ChuaKhoi = (int)Convert.ToDecimal(ChuaKhoiTextEdit.Text);
            tinhHinhChung.TuVong = (int)Convert.ToDecimal(TuVongTextEdit.Text);
            tinhHinhChung.MaNhanVien = MaNhanVienTextEdit.Text;
            if (!tinhHinhChung.Equals(null))
            {
                tinhHinhChungRepository.Update(tinhHinhChung);
                xoaDuLieu();
                MessageBox.Show("Thành công, vui lòng tải lại!");
            }
            else
            {
                MessageBox.Show("Thất bại, vui lòng thử lại!");
            }
            
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numrow = e.RowHandle;
            object data = gridView1.GetRowCellValue(numrow, "Ngay");
            ngayChon = (DateTime) data;
            LoadHangChonChinhSua();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xoaDuLieu();
            loadData();
        }
    }
}
