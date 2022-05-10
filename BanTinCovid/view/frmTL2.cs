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

namespace BanTinCovid.view
{

    public partial class frmTL2 : Form
    {
        TinTucRepository tinTucRepository = new TinTucRepository();
        TheLoaiRepository theLoaiRepository = new TheLoaiRepository();
        TinTucViewModel tinTucViewModel = new TinTucViewModel();
        TheLoaiViewModel theLoaiViewModel = new TheLoaiViewModel();
        List<TinTucViewModel> tintuc;
        List<TheLoaiViewModel> theloai;
        public frmTL2()
        {
            InitializeComponent();
            loadData();
        }
        public async void loadData()
        {
            var listTT = await tinTucRepository.getList();
            var listTL = await theLoaiRepository.getList();
            tintuc = listTT;
            theloai = listTL;
            int i = 0;
            // Tin tức TL2: Chỉ đạo chống dịch
            // List<Product> p_100 = products.FindAll(product => product.Price > 100);
            List<TinTucViewModel> listTTTL2 = await tinTucRepository.GetTTByTheLoai("TL2");
            switch (listTTTL2.Count)
            {
                case 2:
                    {
                        i = 0;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button1.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button2.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        break;
                    }
                case 3:
                    {
                        i = 0;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button1.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button2.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button3.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        break;
                    }
                case 4:
                    {
                        i = 0;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button1.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button2.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button3.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button4.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;

                        break;
                    }
                case 5:
                    {

                        i = 0;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button1.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button2.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button3.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button4.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button5.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;

                        break;
                    }
                case 6:
                    {

                        i = 0;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button1.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button2.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button3.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button4.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button5.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button6.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;

                        break;
                    }
                case 7:
                    {
                        i = 0;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button1.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button2.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button3.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button4.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button5.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button6.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button7.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;


                        break;
                    }
                case 8:
                    {
                        i = 0;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button1.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button2.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button3.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button4.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button5.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button6.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button7.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button7.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;


                        break;
                    }
                case 9:
                    {

                        i = 0;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button1.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button2.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button3.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button4.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button5.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button6.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button7.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button7.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button8.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;
                        i++;
                        tinTucViewModel = listTTTL2[i];
                        tintuc[i] = tinTucViewModel;
                        button9.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine;

                        break;
                    }
            }
        }
    
        private void button1_Click_1(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[3]);
            formHienTinTuc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[4]);
            formHienTinTuc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[5]);
            formHienTinTuc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[6]);
            formHienTinTuc.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[7]);
            formHienTinTuc.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var formHienTinTuc = new frmHienTinTuc(tintuc[8]);
            formHienTinTuc.Show();
        }
    }
}
