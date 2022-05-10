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
    public partial class frmTheLoai : Form
    {
        TheLoaiRepository theLoaiRepository = new TheLoaiRepository();
        public static string maTheLoaiChon;
        public int numrow;
        public frmTheLoai()
        {
            InitializeComponent();
            loadData();
        }
        public async void loadData()
        {
            var listTL = await theLoaiRepository.getList();
            gridControl1.DataSource = listTL;
            //dataLayoutControl_chinhSUa.DataSource = await tinTucRepository.GetTT(maTinTucChon);
        }
        public async void LoadHangChonChinhSua()
        {
            dataLayoutControl1.DataSource = await theLoaiRepository.GetTL(maTheLoaiChon);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numrow = e.RowHandle;
            object data = gridView1.GetRowCellValue(numrow, "MaTheLoai");
            maTheLoaiChon = Convert.ToString(data);
            LoadHangChonChinhSua();
            //MessageBox.Show(maTheLoaiChon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var theLoai = new TheLoaiViewModel();
            theLoai.MaTheLoai = MaTheLoaiTextEdit.Text;
            theLoai.TenTheLoai = TenTheLoaiTextEdit.Text;
            theLoai.TrangThai = Convert.ToInt32(TrangThaiTextEdit.Text);
            theLoai.MoTa = MoTaDataText.Text;
            theLoaiRepository.Add(theLoai);
            MaTheLoaiTextEdit.Text = "";
            TenTheLoaiTextEdit.Text = "";
            TrangThaiTextEdit.Text = "";
            MoTaDataText.Text = "";
            MessageBox.Show("Thành công, vui lòng tải lại!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var theLoai = new TheLoaiViewModel();
            theLoai.MaTheLoai = MaTheLoaiTextEdit.Text;
            theLoai.TenTheLoai = TenTheLoaiTextEdit.Text;
            theLoai.TrangThai = Convert.ToInt32(TrangThaiTextEdit.Text);
            theLoai.MoTa = MoTaDataText.Text;
            theLoaiRepository.Update(theLoai);
            MaTheLoaiTextEdit.Text = "";
            TenTheLoaiTextEdit.Text = "";
            TrangThaiTextEdit.Text = "";
            MoTaDataText.Text = "";
            MessageBox.Show("Thành công, vui lòng tải lại!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                theLoaiRepository.Delete(maTheLoaiChon);
                MessageBox.Show("Thành công, vui lòng tải lại!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {

        }
    }
}
