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
    public partial class frmHienTinTuc : Form
    {

        TinTucRepository tinTucRepository = new TinTucRepository();
        TheLoaiRepository theLoaiRepository = new TheLoaiRepository();
        TinTucViewModel tinTucViewModel = new TinTucViewModel();
        TheLoaiViewModel theLoaiViewModel = new TheLoaiViewModel();
        List<TinTucViewModel> tintuc;
        List<TheLoaiViewModel> theloai;
        
        public frmHienTinTuc(TinTucViewModel temp )
        {
            InitializeComponent();
            tinTucViewModel = temp;
            loadTinTuc();

        }
        public async void loadTinTuc()
        {
            richTextBox1.Text = tinTucViewModel.TenTinTuc + Environment.NewLine + Environment.NewLine + tinTucViewModel.NoiDungNgan + Environment.NewLine + Environment.NewLine + tinTucViewModel.NoiDung + Environment.NewLine + Environment.NewLine + "Tác giả: " + tinTucViewModel.TacGia;
        }
    }
}
