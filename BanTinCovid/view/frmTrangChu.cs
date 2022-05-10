using BanTinCovid.Models;
using BanTinCovid.view;
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

namespace BanTinCovid.view
{
    public partial class frmTrangChu : Form
    {
        TinTucRepository tinTucRepository = new TinTucRepository();
        TheLoaiRepository theLoaiRepository = new TheLoaiRepository();
        TinhHinhChungRepository tinhHinhChungRepository = new TinhHinhChungRepository();
        TinTucViewModel tinTucViewModel = new TinTucViewModel();
        TheLoaiViewModel theLoaiViewModel = new TheLoaiViewModel();
        TinhHinhChungViewModel tinhHinhChungViewModel = new TinhHinhChungViewModel();
        List<TinTucViewModel> tintuc;
        List<TheLoaiViewModel> theloai;
        List<TinhHinhChungViewModel> tinhhinhchung;
        public frmTrangChu()
        {
            InitializeComponent();
            
            loadData();
        }


        public async void loadData()
        {
            var listTT = await tinTucRepository.getList();
            var listTL = await theLoaiRepository.getList();
            var listTHC = await tinhHinhChungRepository.getList();
            tintuc = listTT;
            theloai = listTL;
            tinhhinhchung = listTHC;

            int index = listTHC.Count;
            DateTime ngay = listTHC[index - 1].Ngay;

            TinhHinhChungViewModel thcTC = await tinhHinhChungRepository.GetTHC(ngay);
            richTextBox1.Text = "     SỐ CA NHIỄM " + Environment.NewLine + "      " +thcTC.CaNhiem.ToString();
            richTextBox2.Text = "      CHỮA KHỎI  "+ Environment.NewLine + "      " + thcTC.ChuaKhoi.ToString();
            richTextBox3.Text = "      TỬ VONG     "+ Environment.NewLine + "      " + thcTC.TuVong.ToString();
            // tin tức nổi bật, mới nhất
            // tin tức TL1: bản tin covid-19 Trang chủ
            List<TinTucViewModel> listTTTL1 = await tinTucRepository.GetTTByTheLoai("TL1");
            int i = 0;
            if (listTTTL1.Count >= 3)
            {
                i = listTTTL1.Count - 3;
                TinTucViewModel tinTuc1 = listTTTL1[i];
                tintuc[0] = tinTuc1;
                button1.Text = tinTuc1.TenTinTuc + Environment.NewLine + tinTuc1.NoiDungNgan + Environment.NewLine;
                TinTucViewModel tinTuc2 = listTTTL1[i + 1];
                tintuc[1] = tinTuc2;
                button2.Text = tinTuc2.TenTinTuc + Environment.NewLine + tinTuc1.NoiDungNgan + Environment.NewLine;
                TinTucViewModel tinTuc3 = listTTTL1[i + 2];
                tintuc[2] = tinTuc3;
                button3.Text = tinTuc3.TenTinTuc + Environment.NewLine + tinTuc3.NoiDungNgan + Environment.NewLine;
            }else
            {
                i = 0;

            }

            // Tin tức TL2: Chỉ đạo chống dịch
            // List<Product> p_100 = products.FindAll(product => product.Price > 100);
            List<TinTucViewModel> listTTTL2 = await tinTucRepository.GetTTByTheLoai("TL2");
            if (listTTTL2.Count >= 3)
            {
                i = listTTTL2.Count - 3;
                TinTucViewModel tinTucTL2_1 = listTTTL2[i];
                tintuc[3] = tinTucTL2_1;
                button4.Text = tinTucTL2_1.TenTinTuc + Environment.NewLine + tinTucTL2_1.NoiDungNgan + Environment.NewLine;
                TinTucViewModel tinTucTL2_2 = listTTTL2[i + 1];
                tintuc[4] = tinTucTL2_2;
                button5.Text = tinTucTL2_2.TenTinTuc + Environment.NewLine + tinTucTL2_2.NoiDungNgan + Environment.NewLine;
                TinTucViewModel tinTucTL2_3 = listTTTL2[i + 2];
                tintuc[5] = tinTucTL2_3;
                button6.Text = tinTucTL2_3.TenTinTuc + Environment.NewLine + tinTucTL2_3.NoiDungNgan + Environment.NewLine;
            } else
            {
                i = 0;

            }
            // Tin tức TL3: Dự phòng điều trị
            // List<Product> p_100 = products.FindAll(product => product.Price > 100);
            List<TinTucViewModel> listTTTL3 = await tinTucRepository.GetTTByTheLoai("TL3");
            if (listTTTL3.Count >= 3)
            {
                i = listTTTL3.Count - 3;
                TinTucViewModel tinTucTL3_1 = listTTTL3[i];
                tintuc[6] = tinTucTL3_1;
                button7.Text = tinTucTL3_1.TenTinTuc + Environment.NewLine + tinTucTL3_1.NoiDungNgan + Environment.NewLine;
                TinTucViewModel tinTucTL3_2 = listTTTL3[i + 1];
                tintuc[7] = tinTucTL3_2;
                button8.Text = tinTucTL3_2.TenTinTuc + Environment.NewLine + tinTucTL3_2.NoiDungNgan + Environment.NewLine;
                TinTucViewModel tinTucTL3_3 = listTTTL3[i + 2];
                tintuc[8] = tinTucTL3_3;
                button9.Text = tinTucTL3_3.TenTinTuc + Environment.NewLine + tinTucTL3_3.NoiDungNgan + Environment.NewLine;
            }
            else
            {
                i = 0;

            }
            // Tin tức TL4: Vaccin-Tiêm chủng
            // List<Product> p_100 = products.FindAll(product => product.Price > 100);
            List<TinTucViewModel> listTTTL4 = await tinTucRepository.GetTTByTheLoai("TL4");
            if (listTTTL4.Count >= 3)
            {
                i = listTTTL4.Count - 3;
                TinTucViewModel tinTucTL4_1 = listTTTL4[i];
                tintuc[9] = tinTucTL4_1;
                button10.Text = tinTucTL4_1.TenTinTuc + Environment.NewLine + tinTucTL4_1.NoiDungNgan + Environment.NewLine;
                TinTucViewModel tinTucTL4_2 = listTTTL4[i + 1];
                tintuc[10] = tinTucTL4_2;
                button11.Text = tinTucTL4_2.TenTinTuc + Environment.NewLine + tinTucTL4_2.NoiDungNgan + Environment.NewLine;
                TinTucViewModel tinTucTL4_3 = listTTTL4[i + 2];
                tintuc[11] = tinTucTL4_3;
                button12.Text = tinTucTL4_3.TenTinTuc + Environment.NewLine + tinTucTL4_3.NoiDungNgan + Environment.NewLine;
            }
            else
            {
                i = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[0]);
            formHienTinTuc.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[1]);
            formHienTinTuc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[2]);
            formHienTinTuc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[5]);
            formHienTinTuc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[4]);
            formHienTinTuc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[3]);
            formHienTinTuc.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[8]);
            formHienTinTuc.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[7]);
            formHienTinTuc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[6]);
            formHienTinTuc.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[11]);
            formHienTinTuc.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[10]);
            formHienTinTuc.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[9]);
            formHienTinTuc.Show();
        }
    }
}
