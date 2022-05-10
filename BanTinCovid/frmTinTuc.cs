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
    public partial class frmTinTuc : Form
    {
        private const string V = "";
        int numrow;
        public static int maTinTucChon;
        TinTucRepository tinTucRepository = new TinTucRepository();
        public frmTinTuc()
        {
            InitializeComponent();
            MaNhanVienTextEdit.Text = Program.MaNV;
            loadData();
            
        }
        public async void loadData()
        {
            var listTT = await tinTucRepository.getList();
            gridControl_pageThem.DataSource = listTT;
            gridControl_pageChinhSua.DataSource = listTT;
            //dataLayoutControl_chinhSUa.DataSource = await tinTucRepository.GetTT(maTinTucChon);
        }
        public async void LoadHangChonChinhSua()
        {
            dataLayoutControl_chinhSUa.DataSource = await tinTucRepository.GetTT(maTinTucChon);
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            var TinTuc = new TinTucViewModel();
            TinTuc.TenTinTuc = TenTinTucTextEdit.Text;
            TinTuc.MaTheLoai = MaTheLoaiTextEdit.Text;
            TinTuc.MaNhanVien = Program.MaNV;
            TinTuc.Ngay = NgayDateEdit.DateTime;
            TinTuc.NoiDungNgan = NoiDungNganTextEdit.Text;
            TinTuc.NoiDung = NoiDungTextEdit.Text;
            TinTuc.TacGia = TacGiaTextEdit.Text;
            tinTucRepository.Add(TinTuc);
            TenTinTucTextEdit.Text = "";
            MaTheLoaiTextEdit.Text = "";
            MaNhanVienTextEdit.Text = Program.MaNV;
            //NgayDateEdit.DateTime; // chổ này nào rảnh kiểm lại set datatime thành kiểu null
            NgayDateEdit.Text = "";
            NoiDungNganTextEdit.Text = "";
            NoiDungTextEdit.Text = "";
            TacGiaTextEdit.Text = "";
            MessageBox.Show("Đã thêm tin tức vui lòng tải lại!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TenTinTucTextEdit.Text = "";
            MaTheLoaiTextEdit.Text = "";
            MaNhanVienTextEdit.Text = "" ;
            //NgayDateEdit.DateTime;
            MaNhanVienTextEdit.Text = Program.MaNV;
            NoiDungTextEdit.Text = "";
            TacGiaTextEdit.Text = "";
        }
        // khi nhấn vào một hàng sẽ lưu lại hàng bạn chọn 
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //numrow = e.RowHandle;
            //object data = gridView1.GetRowCellValue(numrow, "MaTinTuc");
            //maTinTucChon = (int)Convert.ToDecimal(data);
            //MessageBox.Show(maTinTucChon.ToString());
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numrow = e.RowHandle;
            object data = gridView1.GetRowCellValue(numrow, "MaTinTuc");
            maTinTucChon = (int)Convert.ToDecimal(data);
            LoadHangChonChinhSua();
            MessageBox.Show(maTinTucChon.ToString());
        }

        private void button_chinhSua_Click(object sender, EventArgs e)
        {
            var TinTuc = new TinTucViewModel();
            TinTuc.TenTinTuc = TenTinTucTextEdit.Text;
            TinTuc.MaTheLoai = MaTheLoaiTextEdit.Text;
            TinTuc.MaNhanVien = Program.MaNV;
            TinTuc.Ngay = NgayDateEdit.DateTime;
            TinTuc.NoiDungNgan = NoiDungNganDataTextHieuChinh.Text;
            TinTuc.NoiDung = NoiDungTextEdit.Text;
            TinTuc.TacGia = TacGiaTextEdit.Text;
            tinTucRepository.Update(TinTuc);
            TenTinTucTextEdit.Text = "";
            MaTheLoaiTextEdit.Text = "";
            MaNhanVienTextEdit.Text = Program.MaNV;
            //NgayDateEdit.DateTime; // chổ này nào rảnh kiểm lại set datatime thành kiểu null

            NoiDungNganTextEdit.Text = "";
            NoiDungTextEdit.Text = "";
            TacGiaTextEdit.Text = "";
            MessageBox.Show("Đã chỉnh sửa tin tức vui lòng tải lại!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //TenTinTucTextEdit.Text = "";
            //MaTheLoaiTextEdit.Text = "";
            //MaNhanVienTextEdit.Text = "";
            ////NgayDateEdit.DateTime;
            //NoiDungNganTextEdit.Text = "";
            //NoiDungTextEdit.Text = "";
            //TacGiaTextEdit.Text = "";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tin tức này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tinTucRepository.Delete(maTinTucChon);
                MessageBox.Show("Đã xóa tin tức vui lòng tải lại!");
            }

        }
    }
}
