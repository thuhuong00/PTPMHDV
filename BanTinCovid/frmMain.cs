using BanTinCovid.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BanTinCovid
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            button_NhanVien.Enabled = button_TheLoai.Enabled = button_TinhHinhChung.Enabled = button_TinTuc.Enabled = false;

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void barButtonItemDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                Program.formDangNhap = new frmDangNhap();
                Program.formDangNhap.MdiParent = this;
                Program.formDangNhap.Show();
            }
        }

        private void button_NhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                Program.formNhanVien = new frmNhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Show();
            }
        }

        private void button_TinTuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTinTuc));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTinTuc = new frmTinTuc();
                Program.formTinTuc.MdiParent = this;
                Program.formTinTuc.Show();
            }
        }

        private void button_TheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTheLoai));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTheLoai = new frmTheLoai();
                Program.formTheLoai.MdiParent = this;
                Program.formTheLoai.Show();
            }
        }

        private void button_TinhHinhChung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTinhHinhChung));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTinhHinhChung = new frmTinhHinhChung();
                Program.formTinhHinhChung.MdiParent = this;
                Program.formTinhHinhChung.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTrangChu));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTrangChu = new frmTrangChu();
                Program.formTrangChu.MdiParent = this;
                Program.formTrangChu.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTL2));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTL2 = new frmTL2();
                Program.formTL2.MdiParent = this;
                Program.formTL2.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTL3));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTL3 = new frmTL3();
                Program.formTL3.MdiParent = this;
                Program.formTL3.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTL4));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTL4 = new frmTL4();
                Program.formTL4.MdiParent = this;
                Program.formTL4.Show();
            }
        }
    }
}
